using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasylEncryptionStandard
{
    public partial class PublicKeyPopup : Form
    {
        public PublicKeyPopup(String t)
        {
            InitializeComponent();
            textBox1.Text = t;
        }

        private void PublicKeyPopup_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
