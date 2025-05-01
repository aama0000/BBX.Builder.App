namespace BBX.Builder.App.Forms
{
    partial class BuildForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblResistance = new Label();
            lblDash = new Label();
            lblStamina = new Label();
            lblDefense = new Label();
            lblAttack = new Label();
            lblWeight = new Label();
            label9 = new Label();
            lstBlade = new ComboBox();
            lblCX = new Label();
            label7 = new Label();
            lstAssist = new ComboBox();
            label10 = new Label();
            lstRatchet = new ComboBox();
            label11 = new Label();
            lstBit = new ComboBox();
            lblPower = new Label();
            label13 = new Label();
            lblHeight = new Label();
            label14 = new Label();
            lblBX = new Label();
            lblUX = new Label();
            label8 = new Label();
            lblBuildName = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Location = new Point(254, 191);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 21;
            label6.Text = "Resistance:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(254, 162);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 20;
            label5.Text = "Dash:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(254, 134);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 19;
            label4.Text = "Stamina:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(254, 105);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 18;
            label3.Text = "Defense:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(254, 77);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 17;
            label2.Text = "Attack:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(254, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 16;
            label1.Text = "Weight:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResistance
            // 
            lblResistance.BorderStyle = BorderStyle.FixedSingle;
            lblResistance.Location = new Point(374, 191);
            lblResistance.Name = "lblResistance";
            lblResistance.Size = new Size(100, 23);
            lblResistance.TabIndex = 27;
            lblResistance.Text = "0";
            lblResistance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDash
            // 
            lblDash.BorderStyle = BorderStyle.FixedSingle;
            lblDash.Location = new Point(374, 162);
            lblDash.Name = "lblDash";
            lblDash.Size = new Size(100, 23);
            lblDash.TabIndex = 26;
            lblDash.Text = "0";
            lblDash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStamina
            // 
            lblStamina.BorderStyle = BorderStyle.FixedSingle;
            lblStamina.Location = new Point(374, 134);
            lblStamina.Name = "lblStamina";
            lblStamina.Size = new Size(100, 23);
            lblStamina.TabIndex = 25;
            lblStamina.Text = "0";
            lblStamina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDefense
            // 
            lblDefense.BorderStyle = BorderStyle.FixedSingle;
            lblDefense.Location = new Point(374, 105);
            lblDefense.Name = "lblDefense";
            lblDefense.Size = new Size(100, 23);
            lblDefense.TabIndex = 24;
            lblDefense.Text = "0";
            lblDefense.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAttack
            // 
            lblAttack.BorderStyle = BorderStyle.FixedSingle;
            lblAttack.Location = new Point(374, 77);
            lblAttack.Name = "lblAttack";
            lblAttack.Size = new Size(100, 23);
            lblAttack.TabIndex = 23;
            lblAttack.Text = "0";
            lblAttack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            lblWeight.BorderStyle = BorderStyle.FixedSingle;
            lblWeight.Location = new Point(374, 38);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(100, 23);
            lblWeight.TabIndex = 22;
            lblWeight.Text = "0";
            lblWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(226, 23);
            label9.TabIndex = 29;
            label9.Text = "Blade";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstBlade
            // 
            lstBlade.FormattingEnabled = true;
            lstBlade.Items.AddRange(new object[] { "Blade", "Assist Blade", "Ratchet", "Bit" });
            lstBlade.Location = new Point(12, 35);
            lstBlade.Name = "lstBlade";
            lstBlade.Size = new Size(226, 23);
            lstBlade.TabIndex = 28;
            lstBlade.SelectedIndexChanged += lstBlade_SelectedIndexChanged;
            // 
            // lblCX
            // 
            lblCX.BackColor = Color.Red;
            lblCX.BorderStyle = BorderStyle.FixedSingle;
            lblCX.ForeColor = Color.White;
            lblCX.Location = new Point(164, 227);
            lblCX.Name = "lblCX";
            lblCX.Size = new Size(74, 23);
            lblCX.TabIndex = 30;
            lblCX.Text = "CX";
            lblCX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(12, 61);
            label7.Name = "label7";
            label7.Size = new Size(226, 23);
            label7.TabIndex = 33;
            label7.Text = "Assist Blade";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstAssist
            // 
            lstAssist.FormattingEnabled = true;
            lstAssist.Items.AddRange(new object[] { "Blade", "Assist Blade", "Ratchet", "Bit" });
            lstAssist.Location = new Point(12, 87);
            lstAssist.Name = "lstAssist";
            lstAssist.Size = new Size(226, 23);
            lstAssist.TabIndex = 32;
            // 
            // label10
            // 
            label10.Location = new Point(12, 113);
            label10.Name = "label10";
            label10.Size = new Size(226, 23);
            label10.TabIndex = 35;
            label10.Text = "Ratchet";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstRatchet
            // 
            lstRatchet.FormattingEnabled = true;
            lstRatchet.Items.AddRange(new object[] { "Blade", "Assist Blade", "Ratchet", "Bit" });
            lstRatchet.Location = new Point(12, 139);
            lstRatchet.Name = "lstRatchet";
            lstRatchet.Size = new Size(226, 23);
            lstRatchet.TabIndex = 34;
            lstRatchet.SelectedIndexChanged += lstRatchet_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Location = new Point(12, 165);
            label11.Name = "label11";
            label11.Size = new Size(226, 23);
            label11.TabIndex = 37;
            label11.Text = "Bit";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstBit
            // 
            lstBit.FormattingEnabled = true;
            lstBit.Items.AddRange(new object[] { "Blade", "Assist Blade", "Ratchet", "Bit" });
            lstBit.Location = new Point(12, 191);
            lstBit.Name = "lstBit";
            lstBit.Size = new Size(226, 23);
            lstBit.TabIndex = 36;
            lstBit.SelectedIndexChanged += lstBit_SelectedIndexChanged;
            // 
            // lblPower
            // 
            lblPower.BorderStyle = BorderStyle.FixedSingle;
            lblPower.Location = new Point(374, 227);
            lblPower.Name = "lblPower";
            lblPower.Size = new Size(100, 23);
            lblPower.TabIndex = 39;
            lblPower.Text = "0";
            lblPower.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Location = new Point(254, 227);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 38;
            label13.Text = "Total Power:";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHeight
            // 
            lblHeight.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Location = new Point(374, 9);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(100, 23);
            lblHeight.TabIndex = 41;
            lblHeight.Text = "0";
            lblHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Location = new Point(254, 9);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 40;
            label14.Text = "Height:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBX
            // 
            lblBX.BackColor = Color.Red;
            lblBX.BorderStyle = BorderStyle.FixedSingle;
            lblBX.ForeColor = Color.White;
            lblBX.Location = new Point(12, 227);
            lblBX.Name = "lblBX";
            lblBX.Size = new Size(74, 23);
            lblBX.TabIndex = 42;
            lblBX.Text = "BX";
            lblBX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUX
            // 
            lblUX.BackColor = Color.Red;
            lblUX.BorderStyle = BorderStyle.FixedSingle;
            lblUX.ForeColor = Color.White;
            lblUX.Location = new Point(88, 227);
            lblUX.Name = "lblUX";
            lblUX.Size = new Size(74, 23);
            lblUX.TabIndex = 43;
            lblUX.Text = "UX";
            lblUX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(12, 259);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 44;
            label8.Text = "Build Name";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBuildName
            // 
            lblBuildName.BorderStyle = BorderStyle.FixedSingle;
            lblBuildName.Location = new Point(88, 259);
            lblBuildName.Name = "lblBuildName";
            lblBuildName.Size = new Size(386, 23);
            lblBuildName.TabIndex = 45;
            lblBuildName.Text = "0";
            lblBuildName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BuildForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 296);
            Controls.Add(lblBuildName);
            Controls.Add(label8);
            Controls.Add(lblUX);
            Controls.Add(lblBX);
            Controls.Add(lblHeight);
            Controls.Add(label14);
            Controls.Add(lblPower);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(lstBit);
            Controls.Add(label10);
            Controls.Add(lstRatchet);
            Controls.Add(label7);
            Controls.Add(lstAssist);
            Controls.Add(lblCX);
            Controls.Add(label9);
            Controls.Add(lstBlade);
            Controls.Add(lblResistance);
            Controls.Add(lblDash);
            Controls.Add(lblStamina);
            Controls.Add(lblDefense);
            Controls.Add(lblAttack);
            Controls.Add(lblWeight);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BuildForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Builder - BBX";
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblResistance;
        private Label lblDash;
        private Label lblStamina;
        private Label lblDefense;
        private Label lblAttack;
        private Label lblWeight;
        private Label label9;
        private ComboBox lstBlade;
        private Label lblCX;
        private Label label7;
        private ComboBox lstAssist;
        private Label label10;
        private ComboBox lstRatchet;
        private Label label11;
        private ComboBox lstBit;
        private Label lblPower;
        private Label label13;
        private Label lblHeight;
        private Label label14;
        private Label lblBX;
        private Label lblUX;
        private Label label8;
        private Label lblBuildName;
    }
}