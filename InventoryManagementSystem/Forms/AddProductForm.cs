using InventoryManagementSystem.Models;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            pageTitleLabel.Text = "Add Product";
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;
        }

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


        // Cancel
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
