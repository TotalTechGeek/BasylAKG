namespace BasylAKG
{
    partial class BasylMainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPublicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPublicKeyFromPEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.generateRSA = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rsaGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ellipticGroupBox = new System.Windows.Forms.GroupBox();
            this.ellipticComboBox = new System.Windows.Forms.ComboBox();
            this.generateEC = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.generateFromFileCheckbox = new System.Windows.Forms.CheckBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.rsaGroupBox.SuspendLayout();
            this.ellipticGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(366, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedToolStripMenuItem,
            this.showPublicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.advancedToolStripMenuItem.Text = "Settings";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.configurationToolStripMenuItem.Text = "Configure Generator";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // showPublicToolStripMenuItem
            // 
            this.showPublicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getPublicKeyFromPEMToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.showPublicToolStripMenuItem.Name = "showPublicToolStripMenuItem";
            this.showPublicToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.showPublicToolStripMenuItem.Text = "Miscellaneous";
            // 
            // getPublicKeyFromPEMToolStripMenuItem
            // 
            this.getPublicKeyFromPEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getPublicKeyToolStripMenuItem});
            this.getPublicKeyFromPEMToolStripMenuItem.Name = "getPublicKeyFromPEMToolStripMenuItem";
            this.getPublicKeyFromPEMToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.getPublicKeyFromPEMToolStripMenuItem.Text = "PEMs";
            this.getPublicKeyFromPEMToolStripMenuItem.Click += new System.EventHandler(this.getPublicKeyFromPEMToolStripMenuItem_Click);
            // 
            // getPublicKeyToolStripMenuItem
            // 
            this.getPublicKeyToolStripMenuItem.Name = "getPublicKeyToolStripMenuItem";
            this.getPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.getPublicKeyToolStripMenuItem.Text = "Get Public Key";
            this.getPublicKeyToolStripMenuItem.Click += new System.EventHandler(this.getPublicKeyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(10, 46);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(152, 20);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(7, 30);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password -";
            // 
            // showPasswordCheckbox
            // 
            this.showPasswordCheckbox.AutoSize = true;
            this.showPasswordCheckbox.Location = new System.Drawing.Point(10, 69);
            this.showPasswordCheckbox.Name = "showPasswordCheckbox";
            this.showPasswordCheckbox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordCheckbox.TabIndex = 4;
            this.showPasswordCheckbox.Text = "Show Password";
            this.showPasswordCheckbox.UseVisualStyleBackColor = true;
            this.showPasswordCheckbox.CheckedChanged += new System.EventHandler(this.showPasswordCheckbox_CheckedChanged);
            // 
            // generateRSA
            // 
            this.generateRSA.Location = new System.Drawing.Point(69, 52);
            this.generateRSA.Name = "generateRSA";
            this.generateRSA.Size = new System.Drawing.Size(97, 28);
            this.generateRSA.TabIndex = 5;
            this.generateRSA.Text = "Generate Key";
            this.generateRSA.UseVisualStyleBackColor = true;
            this.generateRSA.Click += new System.EventHandler(this.generateRSA_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(102, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // rsaGroupBox
            // 
            this.rsaGroupBox.Controls.Add(this.label2);
            this.rsaGroupBox.Controls.Add(this.numericUpDown1);
            this.rsaGroupBox.Controls.Add(this.generateRSA);
            this.rsaGroupBox.Location = new System.Drawing.Point(190, 30);
            this.rsaGroupBox.Name = "rsaGroupBox";
            this.rsaGroupBox.Size = new System.Drawing.Size(172, 86);
            this.rsaGroupBox.TabIndex = 7;
            this.rsaGroupBox.TabStop = false;
            this.rsaGroupBox.Text = "RSA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(Near) Key Size -";
            // 
            // ellipticGroupBox
            // 
            this.ellipticGroupBox.Controls.Add(this.ellipticComboBox);
            this.ellipticGroupBox.Controls.Add(this.generateEC);
            this.ellipticGroupBox.Location = new System.Drawing.Point(190, 121);
            this.ellipticGroupBox.Name = "ellipticGroupBox";
            this.ellipticGroupBox.Size = new System.Drawing.Size(172, 86);
            this.ellipticGroupBox.TabIndex = 8;
            this.ellipticGroupBox.TabStop = false;
            this.ellipticGroupBox.Text = "Elliptic Curve";
            // 
            // ellipticComboBox
            // 
            this.ellipticComboBox.FormattingEnabled = true;
            this.ellipticComboBox.Location = new System.Drawing.Point(6, 25);
            this.ellipticComboBox.Name = "ellipticComboBox";
            this.ellipticComboBox.Size = new System.Drawing.Size(158, 21);
            this.ellipticComboBox.TabIndex = 6;
            // 
            // generateEC
            // 
            this.generateEC.Location = new System.Drawing.Point(69, 52);
            this.generateEC.Name = "generateEC";
            this.generateEC.Size = new System.Drawing.Size(97, 28);
            this.generateEC.TabIndex = 5;
            this.generateEC.Text = "Generate Key";
            this.generateEC.UseVisualStyleBackColor = true;
            this.generateEC.Click += new System.EventHandler(this.generateEC_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pem";
            this.saveFileDialog.Filter = "PEM Files|*.pem|All files|*.*";
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Location = new System.Drawing.Point(10, 121);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.ReadOnly = true;
            this.fileNameTextbox.Size = new System.Drawing.Size(152, 20);
            this.fileNameTextbox.TabIndex = 7;
            this.fileNameTextbox.Visible = false;
            // 
            // generateFromFileCheckbox
            // 
            this.generateFromFileCheckbox.AutoSize = true;
            this.generateFromFileCheckbox.Location = new System.Drawing.Point(10, 191);
            this.generateFromFileCheckbox.Name = "generateFromFileCheckbox";
            this.generateFromFileCheckbox.Size = new System.Drawing.Size(136, 17);
            this.generateFromFileCheckbox.TabIndex = 8;
            this.generateFromFileCheckbox.Text = "Generate Key From File";
            this.generateFromFileCheckbox.UseVisualStyleBackColor = true;
            this.generateFromFileCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(10, 144);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(56, 23);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Visible = false;
            this.browseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(10, 106);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(54, 13);
            this.fileLabel.TabIndex = 9;
            this.fileLabel.Text = "File Path -";
            this.fileLabel.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // BasylMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 233);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.generateFromFileCheckbox);
            this.Controls.Add(this.fileNameTextbox);
            this.Controls.Add(this.ellipticGroupBox);
            this.Controls.Add(this.rsaGroupBox);
            this.Controls.Add(this.showPasswordCheckbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BasylMainForm";
            this.Text = "Basyl Asymmetric Key Generator";
            this.Load += new System.EventHandler(this.BasylMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.rsaGroupBox.ResumeLayout(false);
            this.rsaGroupBox.PerformLayout();
            this.ellipticGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckbox;
        private System.Windows.Forms.Button generateRSA;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox rsaGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ellipticGroupBox;
        private System.Windows.Forms.ComboBox ellipticComboBox;
        private System.Windows.Forms.Button generateEC;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.CheckBox generateFromFileCheckbox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem showPublicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getPublicKeyFromPEMToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem getPublicKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}