using InventoryManagementSystem.Forms;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            pageTitleLabel.Text = "Inventory Management System";
        }

        // Parts
        private void PartAddButton_Click(object sender, System.EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
        }

        // Products
        private void ProductAddButton_Click(object sender, System.EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        // Exit
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
