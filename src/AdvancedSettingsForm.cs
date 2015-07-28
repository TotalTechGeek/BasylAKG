using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BasylEncryptionStandard.GUI
{
    public partial class AdvancedSettingsForm : Form
    {
        private QuickManager manager;

        public AdvancedSettingsForm()
        {
            InitializeComponent();
            manager = new QuickManager();
            this.FormClosing += AdvancedSettingsForm_FormClosing;
            AllowDrop = true;
            DragEnter += AdvancedSettingsForm_DragEnter;
            DragDrop += AdvancedSettingsForm_DragDrop;
        }

        private void AdvancedSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void AdvancedSettingsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void AdvancedSettingsForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFilenames = e.Data.GetData(DataFormats.FileDrop, true) as string[];
            foreach (string filename in droppedFilenames)
            {
                if (System.IO.Path.GetExtension(filename).ToUpperInvariant() == ".CBES")
                {
                    Import(filename);
                }
                break;
            }
        }

        private void AdvancedSettingsForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames =
                       e.Data.GetData(DataFormats.FileDrop, true) as string[];

                bool dropEnabled = true;
                foreach (string filename in filenames)
                {
                    if (System.IO.Path.GetExtension(filename).ToUpperInvariant() != ".CBES")
                    {
                        dropEnabled = false;
                        break;
                    }
                }

                if (dropEnabled)
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        public void SetStats(int initial, int expand, int rounds, int leftoff, string extrakey, bool cipherMode, string seedFunction, bool strongMode)
        {
            InitialUpDown.Value = initial;
            ExpandUpDown.Value = expand;
            RoundsUpDown.Value = rounds;
            LeftoffUpDown.Value = leftoff;
            additionalKeyTextbox.Text = extrakey;
            cipherModeCheckbox.Checked = cipherMode;
            seedFunctionTextbox.Text = seedFunction;
            generationCheckBox.Checked = strongMode;
        }

        public int GetInitial()
        {
            return (int)InitialUpDown.Value;
        }


        public int GetExpand()
        {
            return (int)ExpandUpDown.Value;
        }

        public int GetRounds()
        {
            return (int)RoundsUpDown.Value;
        }

        public int GetLeftoff()
        {

            return (int)LeftoffUpDown.Value;
        }

        public string GetKey()
        {
            return additionalKeyTextbox.Text;
        }

        public string GetSeedFunction()
        {
            return seedFunctionTextbox.Text;
        }


        public bool GetCipherMode()
        {
            return cipherModeCheckbox.Checked;
        }

        public bool GetGenerationMode()
        {
            return generationCheckBox.Checked;
        }
        
        private void submitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Configuration Files|*.cbes";
            sfd.ShowDialog();

            if (sfd.FileName == "") return;

            if (File.Exists(sfd.FileName))
                File.Delete(sfd.FileName);

            StreamWriter writer = new StreamWriter(sfd.FileName);
            writer.WriteLine(GetInitial());
            writer.WriteLine(GetExpand());
            writer.WriteLine(GetRounds());
            writer.WriteLine(GetLeftoff());
            writer.WriteLine(GetKey());
            writer.WriteLine(GetCipherMode());
            writer.WriteLine(GetSeedFunction());
            writer.WriteLine(GetGenerationMode());
            writer.Close();
            writer.Dispose();
        }

        private void Import(string str)
        {
            if (File.Exists(str))
            {
                StreamReader reader = new StreamReader(str);

                InitialUpDown.Value = Int64.Parse(reader.ReadLine());
                ExpandUpDown.Value = Int64.Parse(reader.ReadLine());
                RoundsUpDown.Value = Int64.Parse(reader.ReadLine());
                LeftoffUpDown.Value = Int64.Parse(reader.ReadLine());
                additionalKeyTextbox.Text = reader.ReadLine();

                string s = reader.ReadLine();
                cipherModeCheckbox.Checked = Boolean.Parse(s);

                s = reader.ReadLine();
                seedFunctionTextbox.Text = s;

                s = reader.ReadLine();
                generationCheckBox.Checked = Boolean.Parse(s);



                reader.Close();
                reader.Dispose();
            }
        }

        public void Import()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Configuration Files|*.cbes";
            ofd.ShowDialog();

            Import(ofd.FileName);
           
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.SetSettingsForm(this);
            manager.Show();
            
        }


        private string GenerateRandomFunction(string keyPhrase)
        {
            BasylKeyGenerator generator = new BasylKeyGenerator(keyPhrase, BasylKeyGenerator.INITIAL / 4, BasylKeyGenerator.ROUNDS, BasylKeyGenerator.LEFTOFF, BasylKeyGenerator.EXPANSION / 20, BasylKeyGenerator.ADDITIONALKEY, new byte[32], new byte[4], new byte[4], true, new StrongerBasylPseudoAdaptor());

            List<String> variables = new List<string>();
            List<String> operators = new List<string>();

            variables.Add("seed");
            variables.Add("pos");

            operators.AddRange("+,*,%,^,|,&,+,*,*,+".Split(','));

            bool operMode = false;
            String res = "pos * seed + pos + ";
            while ((generator.GetRandomByte() % 29) != (generator.GetRandomByte() % 29) || !operMode)
            {

                if (operMode)
                {

                    res += operators[generator.GetRandomByte() % operators.Count] + " ";


                    operMode = false;
                }
                else
                {
                    if (generator.GetRandomByte() % 8 == 0)
                    {
                        //literal
                        res += (Math.Abs(BitConverter.ToInt32(new byte[] { generator.GetRandomByte(), generator.GetRandomByte(), generator.GetRandomByte(), generator.GetRandomByte() }, 0)) % 256 * 256 * 12 + " ");
                    }
                    else
                    {
                        //variable
                        res += variables[generator.GetRandomByte() % variables.Count] + " ";
                    }



                    operMode = true;
                }



            }
            return res;
        }

        private void generateFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasylInputBox b =  (new BasylInputBox("Key phrase to generate function."));
            b.ShowDialog();
            seedFunctionTextbox.Text = GenerateRandomFunction(b.GetAnswer());
        }
    }
}
