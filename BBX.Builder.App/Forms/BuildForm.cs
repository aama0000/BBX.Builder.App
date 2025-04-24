using BBX.Builder.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BBX.Builder.App.Forms
{
    public partial class BuildForm : Form
    {
        private List<Blade> allBlades;
        private List<AssistBlade> allAssistBlades;
        private List<Ratchet> allRatchets;
        private List<Bits> allBits;

        public BuildForm()
        {
            InitializeComponent();

            allBlades = LoadAllBlades(@"Data\Blades");
            lstBlade.DataSource = allBlades;
            lstBlade.DisplayMember = "Name";

            allRatchets = LoadAllRatchets(@"Data\Ratchets");
            lstRatchet.DataSource = allRatchets;
            lstRatchet.DisplayMember = "Name";

            allBits = LoadAllBits(@"Data\Bits");
            lstBit.DataSource = allBits;
            lstBit.DisplayMember = "Name";

            allAssistBlades = LoadAllAssistBlades(@"Data\AssistBlades");
            lstAssist.DataSource = allAssistBlades;
            lstAssist.DisplayMember = "Name";

            UpdateStats();

        }

        private void lstBlade_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void lstRatchet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void lstBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void UpdateStats()
        {
            double totalWeight = 0;
            bool isCX = false;
            int totalAttack = 0, totalDefense = 0, totalStamina = 0, totalDash = 0, totalResistance = 0, totalPower = 0, totalHeight = 0;

            if (lstBlade.SelectedItem is Blade b)
            {
                totalWeight += b.Stats.Weight;
                totalAttack += b.Stats.Attack;
                totalDefense += b.Stats.Defense;
                totalStamina += b.Stats.Stamina;
                isCX = b.Stats.CX;
                lstAssist.Enabled = b.Stats.CX;
            }

            if (lstBit.SelectedItem is Bits bit)
            {
                totalWeight += bit.Stats.Weight;
                totalAttack += bit.Stats.Attack;
                totalDefense += bit.Stats.Defense;
                totalStamina += bit.Stats.Stamina;
                totalDash += bit.Stats.Dash;
                totalResistance += bit.Stats.Resistance;
            }

            if (lstRatchet.SelectedItem is Ratchet r)
            {
                totalWeight += r.Stats.Weight;
                totalAttack += r.Stats.Attack;
                totalDefense += r.Stats.Defense;
                totalStamina += r.Stats.Stamina;

            }



            totalPower = totalAttack + totalDefense + totalStamina + totalDash + totalResistance;

            if (isCX)
            {
                lblCX.BackColor = Color.Green;

                if (lstAssist.SelectedItem is AssistBlade a)
                {
                    totalWeight += a.Stats.Weight;
                    totalAttack += a.Stats.Attack;
                    totalDefense += a.Stats.Defense;
                    totalStamina += a.Stats.Stamina;
                    totalHeight += a.Stats.Height;
                }
            }
            else
            {
                lblCX.BackColor = Color.Red;
            }

            lblHeight.Text = "+" + totalHeight.ToString() + "mm";
            lblWeight.Text = totalWeight.ToString("F2") + "g";
            lblAttack.Text = totalAttack.ToString();
            lblDefense.Text = totalDefense.ToString();
            lblStamina.Text = totalStamina.ToString();
            lblDash.Text = totalDash.ToString();
            lblResistance.Text = totalResistance.ToString();
            lblPower.Text = totalPower.ToString();


        }


        public List<Blade> LoadAllBlades(string folderPath)
        {
            List<Blade> blades = new List<Blade>();
            string[] files = Directory.GetFiles(folderPath, "*.xml");

            foreach (string file in files)
            {
                try
                {
                    XDocument doc = XDocument.Load(file);
                    XElement root = doc.Root;

                    Blade blade = new Blade
                    {
                        Name = root.Element("Name")?.Value,
                        Stats = new BladeStats
                        {
                            CX = bool.Parse(root.Element("Stats")?.Element("CX")?.Value ?? "false"),
                            Weight = double.Parse(root.Element("Stats")?.Element("Weight")?.Value ?? "0"),
                            Attack = int.Parse(root.Element("Stats")?.Element("Attack")?.Value ?? "0"),
                            Defense = int.Parse(root.Element("Stats")?.Element("Defense")?.Value ?? "0"),
                            Stamina = int.Parse(root.Element("Stats")?.Element("Stamina")?.Value ?? "0"),
                        }
                    };
                    blades.Add(blade);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load blade from {file}:\n{ex.Message}", "Load Error");
                }
            }

            return blades;
        }

        public List<AssistBlade> LoadAllAssistBlades(string folderPath)
        {
            List<AssistBlade> assistBlades = new List<AssistBlade>();
            string[] files = Directory.GetFiles(folderPath, "*.xml");
            foreach (string file in files)
            {
                try
                {
                    XDocument doc = XDocument.Load(file);
                    XElement root = doc.Root;
                    AssistBlade assistBlade = new AssistBlade
                    {
                        Name = root.Element("Name")?.Value,
                        Stats = new AssistBladeStats
                        {
                            Weight = double.Parse(root.Element("Stats")?.Element("Weight")?.Value ?? "0"),
                            Attack = int.Parse(root.Element("Stats")?.Element("Attack")?.Value ?? "0"),
                            Defense = int.Parse(root.Element("Stats")?.Element("Defense")?.Value ?? "0"),
                            Stamina = int.Parse(root.Element("Stats")?.Element("Stamina")?.Value ?? "0"),
                            Height = int.Parse(root.Element("Stats")?.Element("Height")?.Value ?? "0"),
                        }
                    };
                    assistBlades.Add(assistBlade);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load assist blade from {file}:\n{ex.Message}", "Load Error");
                }
            }
            return assistBlades;
        }

        public List<Ratchet> LoadAllRatchets(string folderPath)
        {
            List<Ratchet> ratchets = new List<Ratchet>();
            string[] files = Directory.GetFiles(folderPath, "*.xml");
            foreach (string file in files)
            {
                try
                {
                    XDocument root = XDocument.Load(file);
                    XElement rootElement = root.Root;
                    Ratchet ratchet = new Ratchet
                    {
                        Name = rootElement.Element("Name")?.Value,
                        Stats = new RatchetStats
                        {
                            Weight = double.Parse(rootElement.Element("Stats")?.Element("Weight")?.Value ?? "0"),
                            Attack = int.Parse(rootElement.Element("Stats")?.Element("Attack")?.Value ?? "0"),
                            Defense = int.Parse(rootElement.Element("Stats")?.Element("Defense")?.Value ?? "0"),
                            Stamina = int.Parse(rootElement.Element("Stats")?.Element("Stamina")?.Value ?? "0"),
                        }

                    };
                    ratchets.Add(ratchet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load ratchet from {file}:\n{ex.Message}", "Load Error");
                }
            }
            return ratchets;
        }

        public List<Bits> LoadAllBits(string folderPath)
        {
            List<Bits> bits = new List<Bits>();
            string[] files = Directory.GetFiles(folderPath, "*.xml");
            foreach (string file in files)
            {
                try
                {
                    XDocument root = XDocument.Load(file);
                    XElement rootElement = root.Root;
                    Bits bit = new Bits
                    {
                        Name = rootElement.Element("Name")?.Value,
                        Stats = new BitStats
                        {
                            Weight = int.Parse(rootElement.Element("Stats")?.Element("Weight")?.Value ?? "0"),
                            Attack = int.Parse(rootElement.Element("Stats")?.Element("Attack")?.Value ?? "0"),
                            Defense = int.Parse(rootElement.Element("Stats")?.Element("Defense")?.Value ?? "0"),
                            Stamina = int.Parse(rootElement.Element("Stats")?.Element("Stamina")?.Value ?? "0"),
                            Dash = int.Parse(rootElement.Element("Stats")?.Element("Dash")?.Value ?? "0"),
                            Resistance = int.Parse(rootElement.Element("Stats")?.Element("Resistance")?.Value ?? "0"),
                        }
                    };
                    bits.Add(bit);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load bits from {file}:\n{ex.Message}", "Load Error");
                }
            }
            return bits;
        }
    }
}
