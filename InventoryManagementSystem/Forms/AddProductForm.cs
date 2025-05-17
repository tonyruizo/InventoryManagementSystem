using InventoryManagementSystem.Models;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class AddProductForm : Form
    {
        private int generatedID;
        private readonly BindingList<Part> associatedParts = new BindingList<Part>();
        public AddProductForm()
        {
            InitializeComponent();
            pageTitleLabel.Text = "Add Product";

            dgvParts.DataSource = Inventory.AllParts;
            dgvAssociatedParts.DataSource = associatedParts;

            dgvParts.Columns["Price"].DefaultCellStyle.Format = "F2";
            dgvAssociatedParts.Columns["Price"].DefaultCellStyle.Format = "F2";

            dgvParts.ReadOnly = true;
            dgvAssociatedParts.ReadOnly = true;

            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvParts.MultiSelect = false;
            dgvAssociatedParts.MultiSelect = false;

            this.Load += AddProductForm_Load;
        }

        /// <summary>
        /// Generate a unique Id for a created product.
        /// </summary>
        /// <returns>A unique Id.</returns>
        private int GenerateUniqueProductID()
        {
            return Inventory.Products.Count > 0 ? Inventory.Products.Max(p => p.ProductID) + 1 : 1;
        }

        // Generate new ProductID on form load
        private void AddProductForm_Load(object sender, System.EventArgs e)
        {
            generatedID = GenerateUniqueProductID();
            productIDTextBox.Text = generatedID.ToString();
            productIDTextBox.Enabled = false;
        }

        // Search parts from the top DataGridView
        private void PartSearchButton_Click(object sender, System.EventArgs e)
        {
            string searchedPart = partSearchText.Text.Trim().ToLower();
            bool isPart = false;

            // Show all parts if field is empty
            if (string.IsNullOrWhiteSpace(searchedPart))
            {
                dgvParts.DataSource = null;
                dgvParts.DataSource = Inventory.AllParts;
                return;
            }

            // Search by ID
            if (int.TryParse(searchedPart, out int partId))
            {
                var match = Inventory.AllParts.FirstOrDefault(p => p.PartID == partId);
                if (match != null)
                {
                    dgvParts.DataSource = new BindingList<Part> { match };
                    isPart = true;
                }
            }
            else
            {
                // Search by Name
                var match = Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchedPart)).ToList();
                if (match.Any())
                {
                    dgvParts.DataSource = new BindingList<Part>(match);
                    isPart = true;
                }
            }

            if (!isPart)
            {
                MessageBox.Show("Part not found.");
                dgvParts.DataSource = null;
                dgvParts.DataSource = Inventory.AllParts;
            }
        }

        // Add Part to associated parts
        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (dgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                if (!associatedParts.Contains(selectedPart))
                {
                    associatedParts.Add(selectedPart);
                }
                else
                {
                    MessageBox.Show("Part has already been added.");
                }
            }
            else
            {
                MessageBox.Show("Please select a part.");
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            if (!int.TryParse(productInventoryTextBox.Text, out int inventory) ||
                !decimal.TryParse(productPriceTextBox.Text, out decimal price) ||
                !int.TryParse(productMinTextBox.Text, out int min) ||
                !int.TryParse(productMaxTextBox.Text, out int max))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            Product newProduct = new Product
            {
                ProductID = generatedID,
                Name = productNameTextBox.Text,
                InStock = inventory,
                Price = price,
                Min = min,
                Max = max
            };

            foreach (Part part in associatedParts)
            {
                newProduct.AssociatedParts.Add(part);
            }

            Inventory.Products.Add(newProduct);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    associatedParts.Remove(selectedPart);
                }
            }
            else
            {
                MessageBox.Show("Select a part to delete.");
            }
        }


        // Cancel
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
