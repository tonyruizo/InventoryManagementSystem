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
            dgvParts.Columns["Price"].DefaultCellStyle.Format = "F2";

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

        // Exit
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
