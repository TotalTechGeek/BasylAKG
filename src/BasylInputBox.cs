using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasylEncryptionStandard.GUI
{
    public partial class BasylInputBox : Form
    {
        public BasylInputBox(string question = "", string title="Basyl Input", string placeholder = "")
        {
            InitializeComponent();
            this.label1.Text = question;
            this.Text = title;
            this.textBox1.Text = placeholder;
        }


        public string GetAnswer()
        {
        
            return textBox1.Text;
        }

        private void BasylInputBox_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Close();
            }
        }
    }
}
