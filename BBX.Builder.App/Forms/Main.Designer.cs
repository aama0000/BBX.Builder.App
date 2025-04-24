namespace BBX.Builder.App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuild = new Button();
            btnDatabase = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnBuild
            // 
            btnBuild.Location = new Point(25, 25);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new Size(154, 62);
            btnBuild.TabIndex = 0;
            btnBuild.Text = "Build";
            btnBuild.UseVisualStyleBackColor = true;
            btnBuild.Click += btnBuild_Click;
            // 
            // btnDatabase
            // 
            btnDatabase.Location = new Point(25, 93);
            btnDatabase.Name = "btnDatabase";
            btnDatabase.Size = new Size(154, 62);
            btnDatabase.TabIndex = 1;
            btnDatabase.Text = "Database";
            btnDatabase.UseVisualStyleBackColor = true;
            btnDatabase.Click += btnDatabase_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(25, 161);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 62);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 247);
            Controls.Add(btnRegister);
            Controls.Add(btnDatabase);
            Controls.Add(btnBuild);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BBX Builder App";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuild;
        private Button btnDatabase;
        private Button btnRegister;
    }
}
