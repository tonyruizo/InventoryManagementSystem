using InventoryManagementSystem.Models;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class ModifyPartForm : Form
    {
        private Part selectedPart;

        public ModifyPartForm(Part partToEdit)
        {
            InitializeComponent();
            selectedPart = partToEdit;
            pageTitleLabel.Text = "Modify Part";
            this.Load += ModifyPartForm_Load;
        }

        // Populate fields with existing data on form load
        private void ModifyPartForm_Load(object sender, System.EventArgs e)
        {
            partIDTextBox.Text = selectedPart.PartID.ToString();
            partIDTextBox.Enabled = false;

            partNameTextBox.Text = selectedPart.Name;
            partInventoryTextBox.Text = selectedPart.InStock.ToString();
            partPriceTextBox.Text = selectedPart.Price.ToString("F2");
            partMinTextBox.Text = selectedPart.Min.ToString();
            partMaxTextBox.Text = selectedPart.Max.ToString();

            if (selectedPart is InHouse inHousePart)
            {
                houseRadioButton.Checked = true;
                partDynamicLabel.Text = "Machine ID";
                partDynamicTextBox.Text = inHousePart.MachineID.ToString();
            }
            else if (selectedPart is OutSourced outsourcedPart)
            {
                outsourcedRadioButton.Checked = true;
                partDynamicLabel.Text = "Company Name";
                partDynamicTextBox.Text = outsourcedPart.CompanyName;
            }
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
                partDynamicLabel.Text = "Company Name";
            }
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

            // Update the existing part
            Part updatedPart;
            if (houseRadioButton.Checked)
            {
                if (!int.TryParse(partDynamicTextBox.Text, out int machineId))
                {
                    MessageBox.Show("Machine ID must be a number.");
                    return;
                }
                updatedPart = new InHouse
                {
                    PartID = selectedPart.PartID,
                    Name = partNameTextBox.Text,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineId
                };
            }
            else
            {
                updatedPart = new OutSourced
                {
                    PartID = selectedPart.PartID,
                    Name = partNameTextBox.Text,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = partDynamicTextBox.Text
                };
            }

            int index = Inventory.AllParts.IndexOf(selectedPart);
            if (index >= 0)
            {
                Inventory.AllParts[index] = updatedPart;
            }

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
