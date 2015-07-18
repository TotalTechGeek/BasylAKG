namespace BasylEncryptionStandard
{

    namespace GUI
    {
        partial class QuickManager
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickManager));
                this.listBox1 = new System.Windows.Forms.ListBox();
                this.button1 = new System.Windows.Forms.Button();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.button3 = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // listBox1
                // 
                this.listBox1.FormattingEnabled = true;
                this.listBox1.Location = new System.Drawing.Point(12, 12);
                this.listBox1.Name = "listBox1";
                this.listBox1.Size = new System.Drawing.Size(114, 160);
                this.listBox1.TabIndex = 0;
                this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(181, 146);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(76, 27);
                this.button1.TabIndex = 1;
                this.button1.Text = "Save";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(132, 120);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(125, 20);
                this.textBox1.TabIndex = 2;
                // 
                // button3
                // 
                this.button3.Location = new System.Drawing.Point(181, 12);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(76, 27);
                this.button3.TabIndex = 4;
                this.button3.Text = "Exit";
                this.button3.UseVisualStyleBackColor = true;
                this.button3.Click += new System.EventHandler(this.button3_Click);
                // 
                // QuickManager
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(269, 185);
                this.Controls.Add(this.button3);
                this.Controls.Add(this.textBox1);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.listBox1);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.Name = "QuickManager";
                this.Text = "QuickManager";
                this.Load += new System.EventHandler(this.QuickManager_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.ListBox listBox1;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.Button button3;
        }
    }
}