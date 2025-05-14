using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Models;
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

            dgvParts.ReadOnly = true;
            dgvProducts.ReadOnly = true;

        }

        // Parts
        private void PartAddButton_Click(object sender, System.EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            if (addPartForm.ShowDialog() == DialogResult.OK)
            {
                dgvParts.DataSource = null;
                dgvParts.DataSource = Inventory.AllParts;
            }
        }

        // Products
        private void ProductAddButton_Click(object sender, System.EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = Inventory.Products;
            }
        }

        // Exit
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
