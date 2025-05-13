using InventoryManagementSystem.Models;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            pageTitleLabel.Text = "Add Part";
        }

        // Handle dyanmic label (in-house = Machine ID /outsourced = Comapany ID)
        private void HouseRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (houseRadioButton.Checked)
            {
                partDynamicLabel.Text = "Machine ID";
            }
            else
            {
                partDynamicLabel.Text = "Company ID";
            }
        }

        /// <summary>
        /// Generate a unique Id for a created part.
        /// </summary>
        /// <returns>A unique Id.</returns>
        private int GenerateUniquePartID()
        {
            return Inventory.AllParts.Count > 0 ? Inventory.AllParts.Max(p => p.PartID) + 1 : 1;
        }


        // Save
        private void PartSaveButton_Click(object sender, System.EventArgs e)
        {
            // Validation
            if (!int.TryParse(partInventoryTextBox.Text, out int inventory) ||
                !decimal.TryParse(partPriceTextBox.Text, out decimal price) ||
                !int.TryParse(partMinTextBox.Text, out int min) ||
                !int.TryParse(partMaxTextBox.Text, out int max))
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

            // Create new part
            Part newPart;
            if (houseRadioButton.Checked)
            {
                if (!int.TryParse(partDynamicTextBox.Text, out int machineId))
                {
                    MessageBox.Show("Machine ID must be a number.");
                    return;
                }
                newPart = new InHouse
                {
                    PartID = GenerateUniquePartID(),
                    Name = partNameLabel.Text,
                    InStock = inventory,
                    Price = price,
                    Max = max,
                    Min = min,
                    MachineID = machineId
                };
            }
            else
            {
                newPart = new OutSourced
                {
                    PartID = GenerateUniquePartID(),
                    Name = partNameLabel.Text,
                    InStock = inventory,
                    Price = price,
                    Max = max,
                    Min = min,
                    CompanyName = partDynamicTextBox.Text
                };
            }
            Inventory.AddPart(newPart);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cancel
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
