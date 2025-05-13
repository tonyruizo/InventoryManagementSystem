using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            pageTitleLabel.Text = "Add Product";
        }



        // Cancel
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
