namespace BasylEncryptionStandard.GUI
{
    partial class AdvancedSettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedSettingsForm));
            this.InitialUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpandUpDown = new System.Windows.Forms.NumericUpDown();
            this.RoundsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.additionalKeyTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LeftoffUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cipherModeCheckbox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.seedFunctionTextbox = new System.Windows.Forms.TextBox();
            this.generationCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.InitialUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpandUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoundsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftoffUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitialUpDown
            // 
            this.InitialUpDown.Location = new System.Drawing.Point(61, 30);
            this.InitialUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.InitialUpDown.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.InitialUpDown.Name = "InitialUpDown";
            this.InitialUpDown.Size = new System.Drawing.Size(100, 20);
            this.InitialUpDown.TabIndex = 0;
            this.InitialUpDown.Value = new decimal(new int[] {
            131072,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expand";
            // 
            // ExpandUpDown
            // 
            this.ExpandUpDown.Location = new System.Drawing.Point(61, 56);
            this.ExpandUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ExpandUpDown.Name = "ExpandUpDown";
            this.ExpandUpDown.Size = new System.Drawing.Size(100, 20);
            this.ExpandUpDown.TabIndex = 2;
            this.ExpandUpDown.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // RoundsUpDown
            // 
            this.RoundsUpDown.Location = new System.Drawing.Point(61, 82);
            this.RoundsUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.RoundsUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RoundsUpDown.Name = "RoundsUpDown";
            this.RoundsUpDown.Size = new System.Drawing.Size(100, 20);
            this.RoundsUpDown.TabIndex = 4;
            this.RoundsUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rounds";
            // 
            // additionalKeyTextbox
            // 
            this.additionalKeyTextbox.Location = new System.Drawing.Point(177, 48);
            this.additionalKeyTextbox.Name = "additionalKeyTextbox";
            this.additionalKeyTextbox.Size = new System.Drawing.Size(146, 20);
            this.additionalKeyTextbox.TabIndex = 6;
            this.additionalKeyTextbox.Text = "ABCD";
            this.toolTip1.SetToolTip(this.additionalKeyTextbox, "Additional key for use in encryption");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Additional Key -";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(241, 156);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(82, 29);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.submitButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Leftoff";
            // 
            // LeftoffUpDown
            // 
            this.LeftoffUpDown.Location = new System.Drawing.Point(61, 108);
            this.LeftoffUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.LeftoffUpDown.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.LeftoffUpDown.Name = "LeftoffUpDown";
            this.LeftoffUpDown.Size = new System.Drawing.Size(100, 20);
            this.LeftoffUpDown.TabIndex = 9;
            this.LeftoffUpDown.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(335, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.managerToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configToolStripMenuItem.Text = "Configuration";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.managerToolStripMenuItem.Text = "Quick Manager";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // cipherModeCheckbox
            // 
            this.cipherModeCheckbox.AutoSize = true;
            this.cipherModeCheckbox.Visible = false;
            this.cipherModeCheckbox.Location = new System.Drawing.Point(15, 134);
            this.cipherModeCheckbox.Name = "cipherModeCheckbox";
            this.cipherModeCheckbox.Size = new System.Drawing.Size(77, 17);
            this.cipherModeCheckbox.TabIndex = 12;
            this.cipherModeCheckbox.Text = "BCS Mode";
            this.toolTip1.SetToolTip(this.cipherModeCheckbox, "Updated version of the BES Encryption Scheme. More secure than standard BES.");
            this.cipherModeCheckbox.UseVisualStyleBackColor = true;
            // 
            // seedFunctionTextbox
            // 
            this.seedFunctionTextbox.ContextMenuStrip = this.contextMenuStrip1;
            this.seedFunctionTextbox.Location = new System.Drawing.Point(177, 97);
            this.seedFunctionTextbox.Name = "seedFunctionTextbox";
            this.seedFunctionTextbox.Size = new System.Drawing.Size(146, 20);
            this.seedFunctionTextbox.TabIndex = 13;
            this.seedFunctionTextbox.Text = "pos * pos + 2 * pos + pos * pos * pos + seed * pos + seed";
            this.toolTip1.SetToolTip(this.seedFunctionTextbox, "Function that the generation array is seeded with");
            // 
            // generationCheckBox
            // 
            this.generationCheckBox.AutoSize = true;
            this.generationCheckBox.Location = new System.Drawing.Point(15, 156);
            this.generationCheckBox.Name = "generationCheckBox";
            this.generationCheckBox.Size = new System.Drawing.Size(154, 17);
            this.generationCheckBox.TabIndex = 15;
            this.generationCheckBox.Text = "Strong Generation Scheme";
            this.toolTip1.SetToolTip(this.generationCheckBox, "Uses a new Generation Scheme that performs deep layered shuffle steps to enhance " +
        "the generation scheme. Does have performance overhead.");
            this.generationCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Seed Function -";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateFunctionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 48);
            // 
            // generateFunctionToolStripMenuItem
            // 
            this.generateFunctionToolStripMenuItem.Name = "generateFunctionToolStripMenuItem";
            this.generateFunctionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.generateFunctionToolStripMenuItem.Text = "Generate Function";
            this.generateFunctionToolStripMenuItem.Click += new System.EventHandler(this.generateFunctionToolStripMenuItem_Click);
            // 
            // AdvancedSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 193);
            this.Controls.Add(this.generationCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.seedFunctionTextbox);
            this.Controls.Add(this.cipherModeCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LeftoffUpDown);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.additionalKeyTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoundsUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpandUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InitialUpDown);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdvancedSettingsForm";
            this.Text = "Advanced";
            this.Load += new System.EventHandler(this.AdvancedSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InitialUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpandUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoundsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftoffUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown InitialUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ExpandUpDown;
        private System.Windows.Forms.NumericUpDown RoundsUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox additionalKeyTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LeftoffUpDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.CheckBox cipherModeCheckbox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox seedFunctionTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox generationCheckBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generateFunctionToolStripMenuItem;
    }
}