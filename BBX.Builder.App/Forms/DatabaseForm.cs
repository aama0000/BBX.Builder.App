using BBX.Builder.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BBX.Builder.App.Forms
{
    public partial class DatabaseForm : Form
    {
        private List<Blade> blades = new();
        private List<AssistBlade> assistBlades = new();
        private List<Ratchet> ratchets = new();
        private List<Bits> bits = new();

        private string bladesPath = @"Data\Blades\";
        private string assistBladesPath = @"Data\AssistBlades\";
        private string ratchetsPath = @"Data\Ratchets\";
        private string bitsPath = @"Data\Bits\";

        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            LoadBlades();
            LoadAssistBlades();
            LoadRatchets();
            LoadBits();
        }
        private void LoadBlades()
        {
            blades = BuildForm.LoadAllBlades(bladesPath);
            lstBlades.DataSource = blades;
            lstBlades.DisplayMember = "Name";
        }

        private void LoadAssistBlades()
        {
            assistBlades = BuildForm.LoadAllAssistBlades(assistBladesPath);
            lstAssistBlades.DataSource = assistBlades;
            lstAssistBlades.DisplayMember = "Name";
        }

        private void LoadRatchets()
        {
            ratchets = BuildForm.LoadAllRatchets(ratchetsPath);
            lstRatchets.DataSource = ratchets;
            lstRatchets.DisplayMember = "Name";
        }

        private void LoadBits()
        {
            bits = BuildForm.LoadAllBits(bitsPath);
            lstBits.DataSource = bits;
            lstBits.DisplayMember = "Name";
        }

        private void lstBlades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBlades.SelectedItem is Blade blade)
            {
                txtBladeName.Text = blade.Name;

                chkBX.Checked = blade.Stats.BX;
                chkUX.Checked = blade.Stats.UX;
                chkCX.Checked = blade.Stats.CX;

                numBladeWeight.Value = (decimal)blade.Stats.Weight;
                numBladeAttack.Value = blade.Stats.Attack;
                numBladeDefense.Value = blade.Stats.Defense;
                numBladeStamina.Value = blade.Stats.Stamina;
            }
        }

        private void lstAssistBlades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAssistBlades.SelectedItem is AssistBlade assist)
            {
                txtAsstName.Text = assist.Name;
                txtAsstAcronym.Text = assist.Acronym;

                numAsstHeight.Value = (decimal)assist.Stats.Height;
                numAsstWeight.Value = (decimal)assist.Stats.Weight;
                numAsstAttack.Value = assist.Stats.Attack;
                numAsstDefense.Value = assist.Stats.Defense;
                numAsstStamina.Value = assist.Stats.Stamina;
            }
        }

        private void lstRatchets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRatchets.SelectedItem is Ratchet ratchet)
            {
                txtRatchetName.Text = ratchet.Name;

                numRatchetHeight.Value = (decimal)ratchet.Stats.Height;
                numRatchetWeight.Value = (decimal)ratchet.Stats.Weight;
                numRatchetAttack.Value = ratchet.Stats.Attack;
                numRatchetDefense.Value = ratchet.Stats.Defense;
                numRatchetStamina.Value = ratchet.Stats.Stamina;
            }
        }

        private void lstBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBits.SelectedItem is Bits bit)
            {
                txtName.Text = bit.Name;
                txtAcronym.Text = bit.Acronym;

                numWeight.Value = (decimal)bit.Stats.Weight;
                numAttack.Value = bit.Stats.Attack;
                numDefense.Value = bit.Stats.Defense;
                numStamina.Value = bit.Stats.Stamina;
                numDash.Value = bit.Stats.Dash;
                numResistance.Value = bit.Stats.Resistance;
            }
        }
    }
}
