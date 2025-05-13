using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm()
        {
            InitializeComponent();
            pageTitleLabel.Text = "Modify Part";
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
