namespace BBX.Builder.App.Forms
{
    partial class DatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemTabs = new TabControl();
            bladeTab = new TabPage();
            label8 = new Label();
            txtBladeName = new TextBox();
            chkUX = new RadioButton();
            lstBlades = new ListBox();
            numBladeWeight = new NumericUpDown();
            chkBX = new RadioButton();
            numBladeAttack = new NumericUpDown();
            label1 = new Label();
            chkCX = new RadioButton();
            numBladeDefense = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            label11 = new Label();
            numBladeStamina = new NumericUpDown();
            label3 = new Label();
            assBladeTab = new TabPage();
            lstAssistBlades = new ListBox();
            numAsstHeight = new NumericUpDown();
            label10 = new Label();
            numAsstStamina = new NumericUpDown();
            numAsstDefense = new NumericUpDown();
            numAsstAttack = new NumericUpDown();
            numAsstWeight = new NumericUpDown();
            label6 = new Label();
            label9 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtAsstAcronym = new TextBox();
            txtAsstName = new TextBox();
            ratchetTabs = new TabPage();
            numRatchetHeight = new NumericUpDown();
            label12 = new Label();
            numRatchetStamina = new NumericUpDown();
            numRatchetDefense = new NumericUpDown();
            numRatchetAttack = new NumericUpDown();
            numRatchetWeight = new NumericUpDown();
            label13 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            txtRatchetName = new TextBox();
            lstRatchets = new ListBox();
            bitsTab = new TabPage();
            numResistance = new NumericUpDown();
            numDash = new NumericUpDown();
            numStamina = new NumericUpDown();
            numDefense = new NumericUpDown();
            numAttack = new NumericUpDown();
            numWeight = new NumericUpDown();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            txtAcronym = new TextBox();
            txtName = new TextBox();
            lstBits = new ListBox();
            button1 = new Button();
            itemTabs.SuspendLayout();
            bladeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBladeWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBladeAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBladeDefense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBladeStamina).BeginInit();
            assBladeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAsstHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAsstStamina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAsstDefense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAsstAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAsstWeight).BeginInit();
            ratchetTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRatchetHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRatchetStamina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRatchetDefense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRatchetAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRatchetWeight).BeginInit();
            bitsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numResistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStamina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDefense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // itemTabs
            // 
            itemTabs.Controls.Add(bladeTab);
            itemTabs.Controls.Add(assBladeTab);
            itemTabs.Controls.Add(ratchetTabs);
            itemTabs.Controls.Add(bitsTab);
            itemTabs.Location = new Point(12, 12);
            itemTabs.Name = "itemTabs";
            itemTabs.SelectedIndex = 0;
            itemTabs.Size = new Size(566, 407);
            itemTabs.TabIndex = 0;
            // 
            // bladeTab
            // 
            bladeTab.Controls.Add(label8);
            bladeTab.Controls.Add(txtBladeName);
            bladeTab.Controls.Add(chkUX);
            bladeTab.Controls.Add(lstBlades);
            bladeTab.Controls.Add(numBladeWeight);
            bladeTab.Controls.Add(chkBX);
            bladeTab.Controls.Add(numBladeAttack);
            bladeTab.Controls.Add(label1);
            bladeTab.Controls.Add(chkCX);
            bladeTab.Controls.Add(numBladeDefense);
            bladeTab.Controls.Add(label2);
            bladeTab.Controls.Add(label4);
            bladeTab.Controls.Add(label11);
            bladeTab.Controls.Add(numBladeStamina);
            bladeTab.Controls.Add(label3);
            bladeTab.Location = new Point(4, 24);
            bladeTab.Name = "bladeTab";
            bladeTab.Padding = new Padding(3);
            bladeTab.Size = new Size(558, 379);
            bladeTab.TabIndex = 0;
            bladeTab.Text = "Blades";
            bladeTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Location = new Point(314, 13);
            label8.Name = "label8";
            label8.Size = new Size(226, 23);
            label8.TabIndex = 45;
            label8.Text = "Name";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBladeName
            // 
            txtBladeName.Location = new Point(314, 39);
            txtBladeName.Name = "txtBladeName";
            txtBladeName.Size = new Size(226, 23);
            txtBladeName.TabIndex = 36;
            // 
            // chkUX
            // 
            chkUX.AutoSize = true;
            chkUX.Location = new Point(500, 69);
            chkUX.Name = "chkUX";
            chkUX.Size = new Size(40, 19);
            chkUX.TabIndex = 58;
            chkUX.TabStop = true;
            chkUX.Text = "UX";
            chkUX.UseVisualStyleBackColor = true;
            // 
            // lstBlades
            // 
            lstBlades.FormattingEnabled = true;
            lstBlades.ItemHeight = 15;
            lstBlades.Location = new Point(15, 13);
            lstBlades.Name = "lstBlades";
            lstBlades.Size = new Size(282, 349);
            lstBlades.TabIndex = 59;
            lstBlades.SelectedIndexChanged += lstBlades_SelectedIndexChanged;
            // 
            // numBladeWeight
            // 
            numBladeWeight.DecimalPlaces = 2;
            numBladeWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numBladeWeight.Location = new Point(406, 96);
            numBladeWeight.Name = "numBladeWeight";
            numBladeWeight.Size = new Size(134, 23);
            numBladeWeight.TabIndex = 47;
            // 
            // chkBX
            // 
            chkBX.AutoSize = true;
            chkBX.Location = new Point(455, 69);
            chkBX.Name = "chkBX";
            chkBX.Size = new Size(39, 19);
            chkBX.TabIndex = 57;
            chkBX.TabStop = true;
            chkBX.Text = "BX";
            chkBX.UseVisualStyleBackColor = true;
            // 
            // numBladeAttack
            // 
            numBladeAttack.Location = new Point(406, 135);
            numBladeAttack.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numBladeAttack.Name = "numBladeAttack";
            numBladeAttack.Size = new Size(134, 23);
            numBladeAttack.TabIndex = 48;
            // 
            // label1
            // 
            label1.Location = new Point(314, 96);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 38;
            label1.Text = "Weight:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkCX
            // 
            chkCX.AutoSize = true;
            chkCX.Location = new Point(406, 69);
            chkCX.Name = "chkCX";
            chkCX.Size = new Size(40, 19);
            chkCX.TabIndex = 56;
            chkCX.TabStop = true;
            chkCX.Text = "CX";
            chkCX.UseVisualStyleBackColor = true;
            // 
            // numBladeDefense
            // 
            numBladeDefense.Location = new Point(406, 164);
            numBladeDefense.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numBladeDefense.Name = "numBladeDefense";
            numBladeDefense.Size = new Size(134, 23);
            numBladeDefense.TabIndex = 49;
            // 
            // label2
            // 
            label2.Location = new Point(314, 135);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 39;
            label2.Text = "Attack:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(314, 193);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 41;
            label4.Text = "Stamina:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Location = new Point(314, 71);
            label11.Name = "label11";
            label11.Size = new Size(70, 23);
            label11.TabIndex = 55;
            label11.Text = "Line:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numBladeStamina
            // 
            numBladeStamina.Location = new Point(406, 193);
            numBladeStamina.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numBladeStamina.Name = "numBladeStamina";
            numBladeStamina.Size = new Size(134, 23);
            numBladeStamina.TabIndex = 50;
            // 
            // label3
            // 
            label3.Location = new Point(314, 164);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 40;
            label3.Text = "Defense:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // assBladeTab
            // 
            assBladeTab.Controls.Add(lstAssistBlades);
            assBladeTab.Controls.Add(numAsstHeight);
            assBladeTab.Controls.Add(label10);
            assBladeTab.Controls.Add(numAsstStamina);
            assBladeTab.Controls.Add(numAsstDefense);
            assBladeTab.Controls.Add(numAsstAttack);
            assBladeTab.Controls.Add(numAsstWeight);
            assBladeTab.Controls.Add(label6);
            assBladeTab.Controls.Add(label9);
            assBladeTab.Controls.Add(label14);
            assBladeTab.Controls.Add(label15);
            assBladeTab.Controls.Add(label16);
            assBladeTab.Controls.Add(label17);
            assBladeTab.Controls.Add(txtAsstAcronym);
            assBladeTab.Controls.Add(txtAsstName);
            assBladeTab.Location = new Point(4, 24);
            assBladeTab.Name = "assBladeTab";
            assBladeTab.Padding = new Padding(3);
            assBladeTab.Size = new Size(558, 379);
            assBladeTab.TabIndex = 1;
            assBladeTab.Text = "Assist Blades";
            assBladeTab.UseVisualStyleBackColor = true;
            // 
            // lstAssistBlades
            // 
            lstAssistBlades.FormattingEnabled = true;
            lstAssistBlades.ItemHeight = 15;
            lstAssistBlades.Location = new Point(15, 13);
            lstAssistBlades.Name = "lstAssistBlades";
            lstAssistBlades.Size = new Size(282, 349);
            lstAssistBlades.TabIndex = 60;
            lstAssistBlades.SelectedIndexChanged += lstAssistBlades_SelectedIndexChanged;
            // 
            // numAsstHeight
            // 
            numAsstHeight.DecimalPlaces = 2;
            numAsstHeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAsstHeight.Location = new Point(406, 131);
            numAsstHeight.Name = "numAsstHeight";
            numAsstHeight.Size = new Size(134, 23);
            numAsstHeight.TabIndex = 52;
            // 
            // label10
            // 
            label10.Location = new Point(314, 131);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 51;
            label10.Text = "Height:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numAsstStamina
            // 
            numAsstStamina.Location = new Point(406, 257);
            numAsstStamina.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numAsstStamina.Name = "numAsstStamina";
            numAsstStamina.Size = new Size(134, 23);
            numAsstStamina.TabIndex = 48;
            // 
            // numAsstDefense
            // 
            numAsstDefense.Location = new Point(406, 228);
            numAsstDefense.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numAsstDefense.Name = "numAsstDefense";
            numAsstDefense.Size = new Size(134, 23);
            numAsstDefense.TabIndex = 47;
            // 
            // numAsstAttack
            // 
            numAsstAttack.Location = new Point(406, 199);
            numAsstAttack.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numAsstAttack.Name = "numAsstAttack";
            numAsstAttack.Size = new Size(134, 23);
            numAsstAttack.TabIndex = 46;
            // 
            // numAsstWeight
            // 
            numAsstWeight.DecimalPlaces = 2;
            numAsstWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAsstWeight.Location = new Point(406, 160);
            numAsstWeight.Name = "numAsstWeight";
            numAsstWeight.Size = new Size(134, 23);
            numAsstWeight.TabIndex = 45;
            // 
            // label6
            // 
            label6.Location = new Point(314, 13);
            label6.Name = "label6";
            label6.Size = new Size(226, 23);
            label6.TabIndex = 44;
            label6.Text = "Name";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(314, 65);
            label9.Name = "label9";
            label9.Size = new Size(226, 23);
            label9.TabIndex = 43;
            label9.Text = "Short Name";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Location = new Point(314, 257);
            label14.Name = "label14";
            label14.Size = new Size(70, 23);
            label14.TabIndex = 40;
            label14.Text = "Stamina:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.Location = new Point(314, 228);
            label15.Name = "label15";
            label15.Size = new Size(70, 23);
            label15.TabIndex = 39;
            label15.Text = "Defense:";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Location = new Point(314, 199);
            label16.Name = "label16";
            label16.Size = new Size(70, 23);
            label16.TabIndex = 38;
            label16.Text = "Attack:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.Location = new Point(314, 160);
            label17.Name = "label17";
            label17.Size = new Size(70, 23);
            label17.TabIndex = 37;
            label17.Text = "Weight:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAsstAcronym
            // 
            txtAsstAcronym.Location = new Point(314, 91);
            txtAsstAcronym.Name = "txtAsstAcronym";
            txtAsstAcronym.Size = new Size(226, 23);
            txtAsstAcronym.TabIndex = 36;
            // 
            // txtAsstName
            // 
            txtAsstName.Location = new Point(314, 39);
            txtAsstName.Name = "txtAsstName";
            txtAsstName.Size = new Size(226, 23);
            txtAsstName.TabIndex = 35;
            // 
            // ratchetTabs
            // 
            ratchetTabs.Controls.Add(numRatchetHeight);
            ratchetTabs.Controls.Add(label12);
            ratchetTabs.Controls.Add(numRatchetStamina);
            ratchetTabs.Controls.Add(numRatchetDefense);
            ratchetTabs.Controls.Add(numRatchetAttack);
            ratchetTabs.Controls.Add(numRatchetWeight);
            ratchetTabs.Controls.Add(label13);
            ratchetTabs.Controls.Add(label19);
            ratchetTabs.Controls.Add(label20);
            ratchetTabs.Controls.Add(label21);
            ratchetTabs.Controls.Add(label22);
            ratchetTabs.Controls.Add(txtRatchetName);
            ratchetTabs.Controls.Add(lstRatchets);
            ratchetTabs.Location = new Point(4, 24);
            ratchetTabs.Name = "ratchetTabs";
            ratchetTabs.Padding = new Padding(3);
            ratchetTabs.Size = new Size(558, 379);
            ratchetTabs.TabIndex = 2;
            ratchetTabs.Text = "Ratchets";
            ratchetTabs.UseVisualStyleBackColor = true;
            // 
            // numRatchetHeight
            // 
            numRatchetHeight.DecimalPlaces = 2;
            numRatchetHeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numRatchetHeight.Location = new Point(406, 79);
            numRatchetHeight.Name = "numRatchetHeight";
            numRatchetHeight.Size = new Size(134, 23);
            numRatchetHeight.TabIndex = 75;
            // 
            // label12
            // 
            label12.Location = new Point(314, 79);
            label12.Name = "label12";
            label12.Size = new Size(70, 23);
            label12.TabIndex = 74;
            label12.Text = "Height:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numRatchetStamina
            // 
            numRatchetStamina.Location = new Point(406, 205);
            numRatchetStamina.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numRatchetStamina.Name = "numRatchetStamina";
            numRatchetStamina.Size = new Size(134, 23);
            numRatchetStamina.TabIndex = 73;
            // 
            // numRatchetDefense
            // 
            numRatchetDefense.Location = new Point(406, 176);
            numRatchetDefense.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numRatchetDefense.Name = "numRatchetDefense";
            numRatchetDefense.Size = new Size(134, 23);
            numRatchetDefense.TabIndex = 72;
            // 
            // numRatchetAttack
            // 
            numRatchetAttack.Location = new Point(406, 147);
            numRatchetAttack.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numRatchetAttack.Name = "numRatchetAttack";
            numRatchetAttack.Size = new Size(134, 23);
            numRatchetAttack.TabIndex = 71;
            // 
            // numRatchetWeight
            // 
            numRatchetWeight.DecimalPlaces = 2;
            numRatchetWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numRatchetWeight.Location = new Point(406, 108);
            numRatchetWeight.Name = "numRatchetWeight";
            numRatchetWeight.Size = new Size(134, 23);
            numRatchetWeight.TabIndex = 70;
            // 
            // label13
            // 
            label13.Location = new Point(314, 13);
            label13.Name = "label13";
            label13.Size = new Size(226, 23);
            label13.TabIndex = 69;
            label13.Text = "Name";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.Location = new Point(314, 205);
            label19.Name = "label19";
            label19.Size = new Size(70, 23);
            label19.TabIndex = 67;
            label19.Text = "Stamina:";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Location = new Point(314, 176);
            label20.Name = "label20";
            label20.Size = new Size(70, 23);
            label20.TabIndex = 66;
            label20.Text = "Defense:";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.Location = new Point(314, 147);
            label21.Name = "label21";
            label21.Size = new Size(70, 23);
            label21.TabIndex = 65;
            label21.Text = "Attack:";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.Location = new Point(314, 108);
            label22.Name = "label22";
            label22.Size = new Size(70, 23);
            label22.TabIndex = 64;
            label22.Text = "Weight:";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRatchetName
            // 
            txtRatchetName.Location = new Point(314, 39);
            txtRatchetName.Name = "txtRatchetName";
            txtRatchetName.Size = new Size(226, 23);
            txtRatchetName.TabIndex = 62;
            // 
            // lstRatchets
            // 
            lstRatchets.FormattingEnabled = true;
            lstRatchets.ItemHeight = 15;
            lstRatchets.Location = new Point(15, 13);
            lstRatchets.Name = "lstRatchets";
            lstRatchets.Size = new Size(282, 349);
            lstRatchets.TabIndex = 61;
            lstRatchets.SelectedIndexChanged += lstRatchets_SelectedIndexChanged;
            // 
            // bitsTab
            // 
            bitsTab.Controls.Add(numResistance);
            bitsTab.Controls.Add(numDash);
            bitsTab.Controls.Add(numStamina);
            bitsTab.Controls.Add(numDefense);
            bitsTab.Controls.Add(numAttack);
            bitsTab.Controls.Add(numWeight);
            bitsTab.Controls.Add(label24);
            bitsTab.Controls.Add(label25);
            bitsTab.Controls.Add(label26);
            bitsTab.Controls.Add(label27);
            bitsTab.Controls.Add(label28);
            bitsTab.Controls.Add(label29);
            bitsTab.Controls.Add(label30);
            bitsTab.Controls.Add(label31);
            bitsTab.Controls.Add(txtAcronym);
            bitsTab.Controls.Add(txtName);
            bitsTab.Controls.Add(lstBits);
            bitsTab.Location = new Point(4, 24);
            bitsTab.Name = "bitsTab";
            bitsTab.Padding = new Padding(3);
            bitsTab.Size = new Size(558, 379);
            bitsTab.TabIndex = 3;
            bitsTab.Text = "Bits";
            bitsTab.UseVisualStyleBackColor = true;
            // 
            // numResistance
            // 
            numResistance.Location = new Point(406, 298);
            numResistance.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numResistance.Name = "numResistance";
            numResistance.Size = new Size(134, 23);
            numResistance.TabIndex = 77;
            // 
            // numDash
            // 
            numDash.Location = new Point(406, 267);
            numDash.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numDash.Name = "numDash";
            numDash.Size = new Size(134, 23);
            numDash.TabIndex = 76;
            // 
            // numStamina
            // 
            numStamina.Location = new Point(406, 227);
            numStamina.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numStamina.Name = "numStamina";
            numStamina.Size = new Size(134, 23);
            numStamina.TabIndex = 75;
            // 
            // numDefense
            // 
            numDefense.Location = new Point(406, 198);
            numDefense.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numDefense.Name = "numDefense";
            numDefense.Size = new Size(134, 23);
            numDefense.TabIndex = 74;
            // 
            // numAttack
            // 
            numAttack.Location = new Point(406, 169);
            numAttack.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numAttack.Name = "numAttack";
            numAttack.Size = new Size(134, 23);
            numAttack.TabIndex = 73;
            // 
            // numWeight
            // 
            numWeight.DecimalPlaces = 2;
            numWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numWeight.Location = new Point(406, 130);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(134, 23);
            numWeight.TabIndex = 72;
            // 
            // label24
            // 
            label24.Location = new Point(314, 13);
            label24.Name = "label24";
            label24.Size = new Size(226, 23);
            label24.TabIndex = 71;
            label24.Text = "Name";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.Location = new Point(314, 65);
            label25.Name = "label25";
            label25.Size = new Size(226, 23);
            label25.TabIndex = 70;
            label25.Text = "Short Name";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            label26.Location = new Point(314, 296);
            label26.Name = "label26";
            label26.Size = new Size(70, 23);
            label26.TabIndex = 69;
            label26.Text = "Resistance:";
            label26.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            label27.Location = new Point(314, 267);
            label27.Name = "label27";
            label27.Size = new Size(70, 23);
            label27.TabIndex = 68;
            label27.Text = "Dash:";
            label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            label28.Location = new Point(314, 227);
            label28.Name = "label28";
            label28.Size = new Size(70, 23);
            label28.TabIndex = 67;
            label28.Text = "Stamina:";
            label28.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            label29.Location = new Point(314, 198);
            label29.Name = "label29";
            label29.Size = new Size(70, 23);
            label29.TabIndex = 66;
            label29.Text = "Defense:";
            label29.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            label30.Location = new Point(314, 169);
            label30.Name = "label30";
            label30.Size = new Size(70, 23);
            label30.TabIndex = 65;
            label30.Text = "Attack:";
            label30.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            label31.Location = new Point(314, 130);
            label31.Name = "label31";
            label31.Size = new Size(70, 23);
            label31.TabIndex = 64;
            label31.Text = "Weight:";
            label31.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAcronym
            // 
            txtAcronym.Location = new Point(314, 91);
            txtAcronym.Name = "txtAcronym";
            txtAcronym.Size = new Size(226, 23);
            txtAcronym.TabIndex = 63;
            // 
            // txtName
            // 
            txtName.Location = new Point(314, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 23);
            txtName.TabIndex = 62;
            // 
            // lstBits
            // 
            lstBits.FormattingEnabled = true;
            lstBits.ItemHeight = 15;
            lstBits.Location = new Point(15, 13);
            lstBits.Name = "lstBits";
            lstBits.Size = new Size(282, 349);
            lstBits.TabIndex = 61;
            lstBits.SelectedIndexChanged += lstBits_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(31, 421);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 60;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 503);
            Controls.Add(button1);
            Controls.Add(itemTabs);
            Name = "DatabaseForm";
            Text = "DatabaseForm";
            Load += DatabaseForm_Load;
            itemTabs.ResumeLayout(false);
            bladeTab.ResumeLayout(false);
            bladeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBladeWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBladeAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBladeDefense).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBladeStamina).EndInit();
            assBladeTab.ResumeLayout(false);
            assBladeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAsstHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAsstStamina).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAsstDefense).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAsstAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAsstWeight).EndInit();
            ratchetTabs.ResumeLayout(false);
            ratchetTabs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRatchetHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRatchetStamina).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRatchetDefense).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRatchetAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRatchetWeight).EndInit();
            bitsTab.ResumeLayout(false);
            bitsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numResistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDash).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStamina).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDefense).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl itemTabs;
        private TabPage bladeTab;
        private TabPage assBladeTab;
        private TabPage ratchetTabs;
        private TabPage bitsTab;
        private ListBox lstBlades;
        private RadioButton chkUX;
        private RadioButton chkBX;
        private RadioButton chkCX;
        private Label label11;
        private NumericUpDown numBladeStamina;
        private NumericUpDown numBladeDefense;
        private NumericUpDown numBladeAttack;
        private NumericUpDown numBladeWeight;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBladeName;
        private ListBox lstAssistBlades;
        private NumericUpDown numAsstHeight;
        private Label label10;
        private NumericUpDown numAsstStamina;
        private NumericUpDown numAsstDefense;
        private NumericUpDown numAsstAttack;
        private NumericUpDown numAsstWeight;
        private Label label6;
        private Label label9;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtAsstAcronym;
        private TextBox txtAsstName;
        private ListBox lstRatchets;
        private ListBox lstBits;
        private NumericUpDown numRatchetHeight;
        private Label label12;
        private NumericUpDown numRatchetStamina;
        private NumericUpDown numRatchetDefense;
        private NumericUpDown numRatchetAttack;
        private NumericUpDown numRatchetWeight;
        private Label label13;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txtRatchetName;
        private NumericUpDown numResistance;
        private NumericUpDown numDash;
        private NumericUpDown numStamina;
        private NumericUpDown numDefense;
        private NumericUpDown numAttack;
        private NumericUpDown numWeight;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private TextBox txtAcronym;
        private TextBox txtName;
        private Button button1;
    }
}