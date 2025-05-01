using BBX.Builder.App.Models;

namespace BBX.Builder.App.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ItemLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ItemLst.SelectedItem;

            switch (selectedItem)
            {
                case "Blade":
                    // Handle Item 1 selection
                    txtName.Enabled = true;
                    txtAcronym.Enabled = true;
                    chkCX.Visible = true;
                    numHeight.Enabled = false;
                    numWeight.Enabled = true;
                    numAttack.Enabled = true;
                    numDefense.Enabled = true;
                    numStamina.Enabled = true;
                    numDash.Enabled = false;
                    numResistance.Enabled = false;

                    break;
                case "Assist Blade":
                    // Handle Item 2 selection
                    txtName.Enabled = true;
                    txtAcronym.Enabled = true;
                    chkCX.Visible = false;
                    numHeight.Enabled = true;
                    numWeight.Enabled = true;
                    numAttack.Enabled = true;
                    numDefense.Enabled = true;
                    numStamina.Enabled = true;
                    numDash.Enabled = false;
                    numResistance.Enabled = false;
                    break;
                case "Ratchet":
                    // Handle Item 3 selection
                    txtName.Enabled = true;
                    txtAcronym.Enabled = false;
                    chkCX.Visible = false;
                    numHeight.Enabled = true;
                    numWeight.Enabled = true;
                    numAttack.Enabled = true;
                    numDefense.Enabled = true;
                    numStamina.Enabled = true;
                    numDash.Enabled = false;
                    numResistance.Enabled = false;
                    break;
                case "Bit":
                    // Handle Item 3 selection
                    txtName.Enabled = true;
                    txtAcronym.Enabled = true;
                    chkCX.Visible = false;
                    numHeight.Enabled = false;
                    numWeight.Enabled = true;
                    numAttack.Enabled = true;
                    numDefense.Enabled = true;
                    numStamina.Enabled = true;
                    numDash.Enabled = true;
                    numResistance.Enabled = true;
                    break;
                default:
                    // Handle default case
                    txtName.Enabled = false;
                    txtAcronym.Enabled = false;
                    chkCX.Enabled = false;
                    numHeight.Enabled = false;
                    numWeight.Enabled = false;
                    numAttack.Enabled = false;
                    numDefense.Enabled = false;
                    numStamina.Enabled = false;
                    numDash.Enabled = false;
                    numResistance.Enabled = false;
                    break;
            }
            // Clear the fields when a new item type is selected
            txtName.Clear();
            txtAcronym.Clear();
            numWeight.Value = 0;
            numAttack.Value = 0;
            numDefense.Value = 0;
            numStamina.Value = 0;
            numDash.Value = 0;
            numResistance.Value = 0;
            chkCX.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form when the Cancel button is clicked
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (ItemLst.SelectedItem == null)
            {
                MessageBox.Show("Please select an item type.");
                return;
            }
            if (numWeight.Value <= 0)
            {
                MessageBox.Show("Please enter a valid weight.");
                return;
            }

            saveData();
        }

        private void saveData()
        {
            var selectedItem = ItemLst.SelectedItem;

            switch (selectedItem)
            {
                case "Blade":
                    saveBlade();
                    break;
                case "Assist Blade":
                    saveAssistBlade();
                    break;
                case "Ratchet":
                    saveRatchet();
                    break;
                case "Bit":
                    saveBit();
                    break;
                default:
                    MessageBox.Show("Please select a valid item type.");
                    break;
            }

            // Clear the fields after saving
            txtName.Clear();
            txtAcronym.Clear();
            numHeight.Value = 0;
            numWeight.Value = 0;
            numAttack.Value = 0;
            numDefense.Value = 0;
            numStamina.Value = 0;
            numDash.Value = 0;
            numResistance.Value = 0;

            MessageBox.Show(selectedItem + " saved successfully.");

        }

        private void saveBit()
        {
            var bit = new Bits
            {
                Name = txtName.Text,
                Acronym = txtAcronym.Text,
                Stats = new BitStats
                {
                    Weight = (double)numWeight.Value,
                    Attack = (int)numAttack.Value,
                    Defense = (int)numDefense.Value,
                    Stamina = (int)numStamina.Value,
                    Dash = (int)numDash.Value,
                    Resistance = (int)numResistance.Value
                }
            };
            XmlHelper.SaveToXml($"Data/Bits/{bit.Name}.xml", bit);
        }

        private void saveRatchet()
        {
            var ratchet = new Ratchet
            {
                Name = txtName.Text,
                Stats = new RatchetStats
                {
                    Weight = (double)numWeight.Value,
                    Attack = (int)numAttack.Value,
                    Defense = (int)numDefense.Value,
                    Stamina = (int)numStamina.Value,
                    Height = (int)numHeight.Value
                }
            };
            XmlHelper.SaveToXml($"Data/Ratchets/{ratchet.Name}.xml", ratchet);
        }

        private void saveAssistBlade()
        {
            var assistBlade = new AssistBlade
            {
                Name = txtName.Text,
                Acronym = txtAcronym.Text,
                Stats = new AssistBladeStats
                {
                    Weight = (double)numWeight.Value,
                    Attack = (int)numAttack.Value,
                    Defense = (int)numDefense.Value,
                    Stamina = (int)numStamina.Value,
                    Height = (int)numHeight.Value
                }
            };

            XmlHelper.SaveToXml($"Data/AssistBlades/{assistBlade.Name}.xml", assistBlade);
        }

        private void saveBlade()
        {
            var blade = new Blade
            {
                Name = txtName.Text,
                Stats = new BladeStats
                {
                    CX = chkCX.Checked,
                    BX = chkBX.Checked,
                    UX = chkUX.Checked,
                    Weight = (double)numWeight.Value,
                    Attack = (int)numAttack.Value,
                    Defense = (int)numDefense.Value,
                    Stamina = (int)numStamina.Value
                }
            };

            XmlHelper.SaveToXml($"Data/Blades/{blade.Name}.xml", blade);
        }
    }
}
