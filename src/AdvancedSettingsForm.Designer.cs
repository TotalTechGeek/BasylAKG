namespace BasylEncryptionStandard
{
    namespace GUI
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
                this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                ((System.ComponentModel.ISupportInitialize)(this.InitialUpDown)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.ExpandUpDown)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.RoundsUpDown)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.LeftoffUpDown)).BeginInit();
                this.menuStrip1.SuspendLayout();
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
            200,
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
                this.additionalKeyTextbox.Location = new System.Drawing.Point(15, 165);
                this.additionalKeyTextbox.Name = "additionalKeyTextbox";
                this.additionalKeyTextbox.Size = new System.Drawing.Size(146, 20);
                this.additionalKeyTextbox.TabIndex = 6;
                this.additionalKeyTextbox.Text = "ABCD";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(12, 149);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(80, 13);
                this.label4.TabIndex = 7;
                this.label4.Text = "Additional Key -";
                // 
                // SubmitButton
                // 
                this.SubmitButton.Location = new System.Drawing.Point(46, 197);
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
                this.menuStrip1.Size = new System.Drawing.Size(180, 24);
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
                this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                this.importToolStripMenuItem.Text = "Import";
                this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
                // 
                // exportToolStripMenuItem
                // 
                this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
                this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                this.exportToolStripMenuItem.Text = "Export";
                this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
                // 
                // managerToolStripMenuItem
                // 
                this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
                this.managerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
                this.managerToolStripMenuItem.Text = "Quick Manager";
                this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
                // 
                // toolStripSeparator1
                // 
                this.toolStripSeparator1.Name = "toolStripSeparator1";
                this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
                // 
                // AdvancedSettingsForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(180, 232);
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
        }
    }
}