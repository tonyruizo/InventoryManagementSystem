using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Models;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            pageTitleLabel.Text = "Inventory Management System";
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;
            dgvParts.Columns["Price"].DefaultCellStyle.Format = "F2";
            dgvProducts.Columns["Price"].DefaultCellStyle.Format = "F2";

            dgvParts.ReadOnly = true;
            dgvProducts.ReadOnly = true;

            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;

            LoadTestData();

        }

        // Data for testing
        private void LoadTestData()
        {
            Inventory.AddPart(new InHouse
            {
                PartID = 1,
                Name = "Plywood",
                InStock = 10,
                Price = 39.99m,
                Min = 1,
                Max = 20,
                MachineID = 23
            });

            Inventory.AddPart(new OutSourced
            {
                PartID = 2,
                Name = "Tape",
                InStock = 5,
                Price = 5.18m,
                Min = 1,
                Max = 10,
                CompanyName = "Home Depot"
            });

            Inventory.AddPart(new InHouse
            {
                PartID = 3,
                Name = "Hammer",
                InStock = 10,
                Price = 9.99m,
                Min = 1,
                Max = 20,
                MachineID = 20
            });

            Inventory.AddProduct(new Product
            {
                ProductID = 1,
                Name = "Glue",
                InStock = 2,
                Price = 1.99m,
                Min = 1,
                Max = 5
            });

            Inventory.AddProduct(new Product
            {
                ProductID = 2,
                Name = "100 Nails Box",
                InStock = 6,
                Price = 8.99m,
                Min = 1,
                Max = 10
            });
        }

        // Parts
        private void PartAddButton_Click(object sender, System.EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            if (addPartForm.ShowDialog() == DialogResult.OK)
            {
                dgvParts.DataSource = null;
                dgvParts.DataSource = Inventory.AllParts;
                dgvParts.Columns["Price"].DefaultCellStyle.Format = "F2";
            }
        }

        private void PartModifyButton_Click(object sender, System.EventArgs e)
        {
            if (dgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                ModifyPartForm modifyForm = new ModifyPartForm(selectedPart);
                if (modifyForm.ShowDialog() == DialogResult.OK)
                {
                    dgvParts.DataSource = null;
                    dgvParts.DataSource = Inventory.AllParts;
                }
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
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
                var match = Inventory.LookupPart(partId);
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

        private void PartDeleteButton_Click(object sender, System.EventArgs e)
        {
            if (dgvParts.SelectedRows.Count == 0 || dgvParts.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            if (dgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                bool isAssociated = Inventory.Products.Any(p =>
            p.AssociatedParts.Any(ap => ap.PartID == selectedPart.PartID));

                if (isAssociated)
                {
                    MessageBox.Show("This part cannot be deleted.");
                    return;
                }

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this part?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    Inventory.DeletePart(selectedPart);
                    dgvParts.DataSource = null;
                    dgvParts.DataSource = Inventory.AllParts;
                    MessageBox.Show("Part deleted.");
                }
            }

        }

        // Products
        private void ProductAddButton_Click(object sender, System.EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                dgvProducts.DataSource = null;
                dgvParts.Columns["Price"].DefaultCellStyle.Format = "F2";
                dgvProducts.DataSource = Inventory.Products;
            }
        }

        private void ProductSearchButton_Click(object sender, System.EventArgs e)
        {
            string searchedProduct = productSearchText.Text.Trim().ToLower();
            bool isProduct = false;

            // Show all products if field is empty
            if (string.IsNullOrWhiteSpace(searchedProduct))
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = Inventory.Products;
                return;
            }

            // Search by ID
            if (int.TryParse(searchedProduct, out int productId))
            {
                var match = Inventory.LookupProduct(productId);
                if (match != null)
                {
                    dgvProducts.DataSource = new BindingList<Product> { match };
                    isProduct = true;
                }
            }
            else
            {
                // Search by Name
                var match = Inventory.Products.Where(p => p.Name.ToLower().Contains(searchedProduct)).ToList();
                if (match.Any())
                {
                    dgvProducts.DataSource = new BindingList<Product>(match);
                    isProduct = true;
                }
            }

            if (!isProduct)
            {
                MessageBox.Show("Product not found.");
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = Inventory.Products;
            }

        }

        private void ProductDeleteButton_Click(object sender, System.EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0 || dgvProducts.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            if (dgvProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                if (selectedProduct.AssociatedParts.Any())
                {
                    MessageBox.Show("This product cannot be deleted because it has an associated part.");
                    return;
                }

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    Inventory.RemoveProduct(selectedProduct.ProductID);
                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = Inventory.Products;
                    MessageBox.Show("Product deleted.");
                }
            }
        }


        // Exit
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
