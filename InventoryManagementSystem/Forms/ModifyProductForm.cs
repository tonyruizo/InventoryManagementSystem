using InventoryManagementSystem.Models;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class ModifyProductForm : Form
    {
        private readonly Product originalProduct;
        private readonly BindingList<Part> associatedParts;
        public ModifyProductForm(Product productToModify)
        {
            InitializeComponent();
            pageTitleLabel.Text = "Modify Product";
            this.Size = new Size(1100, 600);

            originalProduct = productToModify;
            associatedParts = new BindingList<Part>(productToModify.AssociatedParts.ToList());

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

            Load += ModifyProductForm_Load;
        }

        private void ModifyProductForm_Load(object sender, System.EventArgs e)
        {
            productIDTextBox.Text = originalProduct.ProductID.ToString();
            productIDTextBox.Enabled = false;

            productNameTextBox.Text = originalProduct.Name;
            productInventoryTextBox.Text = originalProduct.InStock.ToString();
            productPriceTextBox.Text = originalProduct.Price.ToString("F2");
            productMinTextBox.Text = originalProduct.Min.ToString();
            productMaxTextBox.Text = originalProduct.Max.ToString();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (dgvParts.CurrentRow?.DataBoundItem is Part selectedPart &&
                !associatedParts.Contains(selectedPart))
            {
                associatedParts.Add(selectedPart);
            }
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var result = MessageBox.Show("Are you sure you want to remove this associated part?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    associatedParts.Remove(selectedPart);
                }
            }
            else
            {
                MessageBox.Show("Select an associated part to delete.");
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

            Product updatedProduct = new Product
            {
                ProductID = originalProduct.ProductID,
                Name = productNameTextBox.Text,
                InStock = inventory,
                Price = price,
                Min = min,
                Max = max
            };

            foreach (Part part in associatedParts)
            {
                updatedProduct.AddAssociatedParts(part);
            }

            Inventory.UpdateProduct(originalProduct.ProductID, updatedProduct);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
