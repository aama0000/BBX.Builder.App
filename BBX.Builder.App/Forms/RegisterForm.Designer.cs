namespace BBX.Builder.App.Forms
{
    partial class RegisterForm
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
            ItemLst = new ComboBox();
            txtName = new TextBox();
            txtAcronym = new TextBox();
            chkCX = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            numWeight = new NumericUpDown();
            numAttack = new NumericUpDown();
            numDefense = new NumericUpDown();
            numStamina = new NumericUpDown();
            numDash = new NumericUpDown();
            numResistance = new NumericUpDown();
            numHeight = new NumericUpDown();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDefense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStamina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numResistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            SuspendLayout();
            // 
            // ItemLst
            // 
            ItemLst.FormattingEnabled = true;
            ItemLst.Items.AddRange(new object[] { "Blade", "Assist Blade", "Ratchet", "Bit" });
            ItemLst.Location = new Point(12, 35);
            ItemLst.Name = "ItemLst";
            ItemLst.Size = new Size(226, 23);
            ItemLst.TabIndex = 0;
            ItemLst.SelectedIndexChanged += ItemLst_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 23);
            txtName.TabIndex = 1;
            // 
            // txtAcronym
            // 
            txtAcronym.Location = new Point(12, 139);
            txtAcronym.Name = "txtAcronym";
            txtAcronym.Size = new Size(226, 23);
            txtAcronym.TabIndex = 2;
            // 
            // chkCX
            // 
            chkCX.AutoSize = true;
            chkCX.Location = new Point(12, 170);
            chkCX.Name = "chkCX";
            chkCX.Size = new Size(66, 19);
            chkCX.TabIndex = 9;
            chkCX.Text = "CX Line";
            chkCX.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(12, 226);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 10;
            label1.Text = "Weight:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(12, 265);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 11;
            label2.Text = "Attack:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(12, 294);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 12;
            label3.Text = "Defense:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(12, 323);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 13;
            label4.Text = "Stamina:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(12, 363);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 14;
            label5.Text = "Dash:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(12, 392);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 15;
            label6.Text = "Resistance:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(12, 113);
            label7.Name = "label7";
            label7.Size = new Size(226, 23);
            label7.TabIndex = 16;
            label7.Text = "Short Name";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(12, 61);
            label8.Name = "label8";
            label8.Size = new Size(226, 23);
            label8.TabIndex = 17;
            label8.Text = "Name";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(226, 23);
            label9.TabIndex = 18;
            label9.Text = "Item";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 428);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(226, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 457);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(226, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // numWeight
            // 
            numWeight.DecimalPlaces = 2;
            numWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numWeight.Location = new Point(118, 226);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(120, 23);
            numWeight.TabIndex = 21;
            // 
            // numAttack
            // 
            numAttack.Location = new Point(118, 265);
            numAttack.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numAttack.Name = "numAttack";
            numAttack.Size = new Size(120, 23);
            numAttack.TabIndex = 22;
            // 
            // numDefense
            // 
            numDefense.Location = new Point(118, 294);
            numDefense.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numDefense.Name = "numDefense";
            numDefense.Size = new Size(120, 23);
            numDefense.TabIndex = 23;
            // 
            // numStamina
            // 
            numStamina.Location = new Point(118, 323);
            numStamina.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numStamina.Name = "numStamina";
            numStamina.Size = new Size(120, 23);
            numStamina.TabIndex = 24;
            // 
            // numDash
            // 
            numDash.Location = new Point(118, 363);
            numDash.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numDash.Name = "numDash";
            numDash.Size = new Size(120, 23);
            numDash.TabIndex = 25;
            // 
            // numResistance
            // 
            numResistance.Location = new Point(118, 394);
            numResistance.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numResistance.Name = "numResistance";
            numResistance.Size = new Size(120, 23);
            numResistance.TabIndex = 26;
            // 
            // numHeight
            // 
            numHeight.DecimalPlaces = 2;
            numHeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numHeight.Location = new Point(118, 197);
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(120, 23);
            numHeight.TabIndex = 28;
            // 
            // label10
            // 
            label10.Location = new Point(12, 197);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 27;
            label10.Text = "Height:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(254, 494);
            Controls.Add(numHeight);
            Controls.Add(label10);
            Controls.Add(numResistance);
            Controls.Add(numDash);
            Controls.Add(numStamina);
            Controls.Add(numDefense);
            Controls.Add(numAttack);
            Controls.Add(numWeight);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkCX);
            Controls.Add(txtAcronym);
            Controls.Add(txtName);
            Controls.Add(ItemLst);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register - BBX";
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDefense).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStamina).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDash).EndInit();
            ((System.ComponentModel.ISupportInitialize)numResistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ItemLst;
        private TextBox txtName;
        private TextBox txtAcronym;
        private CheckBox chkCX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSave;
        private Button btnCancel;
        private NumericUpDown numWeight;
        private NumericUpDown numAttack;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numDefense;
        private NumericUpDown numStamina;
        private NumericUpDown numDash;
        private NumericUpDown numResistance;
        private NumericUpDown numHeight;
        private Label label10;
    }
}