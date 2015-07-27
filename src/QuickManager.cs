using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BasylEncryptionStandard.GUI
{
    public partial class QuickManager : Form
    {
        private AdvancedSettingsForm form;

        private readonly string BESFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "BES";
            

        public QuickManager()
        {
            InitializeComponent();
            this.FormClosing += QuickManager_FormClosing;
        }

        private void QuickManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }


        /// <summary>
        /// Run this when it is shown, please.
        /// </summary>
        /// <param name="form"></param>
        public void SetSettingsForm(AdvancedSettingsForm form)
        {
            this.form = form;
            
            if (!Directory.Exists(BESFolder))
            {
                Directory.CreateDirectory(BESFolder);
            }

            RefreshElements();
           
        }

        private void RefreshElements()
        {
            string[] n = Directory.GetFiles(BESFolder);

            listBox1.Items.Clear();
            foreach (string file in n)
            {
                if (Path.GetExtension(file) == ".cbes")
                {
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }

        }

        private void QuickManager_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadConfiguration()
        {
            if (listBox1.SelectedItem == null) return;

            string file = Path.Combine(BESFolder, listBox1.SelectedItem.ToString() + ".cbes");
            if (File.Exists(file))
            {
                StreamReader reader = new StreamReader(file);

                form.SetStats(Int32.Parse(reader.ReadLine()),
                Int32.Parse(reader.ReadLine()),
                Int32.Parse(reader.ReadLine()),
                Int32.Parse(reader.ReadLine()),
                reader.ReadLine(), Boolean.Parse(reader.ReadLine()), reader.ReadLine(), Boolean.Parse(reader.ReadLine()));

                reader.Close();
                reader.Dispose();
            }

            RefreshElements();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                string file = Path.Combine(BESFolder, textBox1.Text + ".cbes");




                if (File.Exists(file))
                    File.Delete(file);

                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(form.GetInitial());
                writer.WriteLine(form.GetExpand());
                writer.WriteLine(form.GetRounds());
                writer.WriteLine(form.GetLeftoff());
                writer.WriteLine(form.GetKey());
                writer.WriteLine(form.GetCipherMode());
                writer.WriteLine(form.GetSeedFunction());
                writer.WriteLine(form.GetGenerationMode());
                writer.Close();
                writer.Dispose();

                RefreshElements();


                this.Close();
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) 
            this.textBox1.Text = listBox1.SelectedItem.ToString();

            LoadConfiguration();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
