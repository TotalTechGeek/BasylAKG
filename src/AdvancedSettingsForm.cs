using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BasylEncryptionStandard
{
    namespace GUI
    {
        public partial class AdvancedSettingsForm : Form
        {
            private QuickManager manager;

            //private static AdvancedSettingsForm globalInstance = new AdvancedSettingsForm();
            /*
            /// <summary>
            /// This is a temporary hack.
            /// </summary>
            /// <returns></returns>
            public static AdvancedSettingsForm GetGlobal()
            {
                return globalInstance;
            }
            */
            public AdvancedSettingsForm()
            {
                InitializeComponent();
                manager = new QuickManager();
            }

            private void AdvancedSettingsForm_Load(object sender, EventArgs e)
            {

            }


            public void SetStats(int initial, int expand, int rounds, int leftoff, string extrakey)
            {
                InitialUpDown.Value = initial;
                ExpandUpDown.Value = expand;
                RoundsUpDown.Value = rounds;
                LeftoffUpDown.Value = leftoff;
                additionalKeyTextbox.Text = extrakey;
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

            private void submitButtonClick(object sender, EventArgs e)
            {
                this.Close();
            }

            private void exportToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (File.Exists("configuration.cbes"))
                    File.Delete("configuration.cbes");

                StreamWriter writer = new StreamWriter("configuration.cbes");
                writer.WriteLine(GetInitial());
                writer.WriteLine(GetExpand());
                writer.WriteLine(GetRounds());
                writer.WriteLine(GetLeftoff());
                writer.WriteLine(GetKey());
                writer.Close();
                writer.Dispose();
            }

            public void Import()
            {
                if (File.Exists("configuration.cbes"))
                {
                    StreamReader reader = new StreamReader("configuration.cbes");

                    InitialUpDown.Value = Int64.Parse(reader.ReadLine());
                    ExpandUpDown.Value = Int64.Parse(reader.ReadLine());
                    RoundsUpDown.Value = Int64.Parse(reader.ReadLine());
                    LeftoffUpDown.Value = Int64.Parse(reader.ReadLine());
                    additionalKeyTextbox.Text = reader.ReadLine();
                    reader.Close();
                    reader.Dispose();
                }
            }

            private void importToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Import();
            }

            private void managerToolStripMenuItem_Click(object sender, EventArgs e)
            {
                manager.SetSettingsForm(this);
                manager.ShowDialog();

            }
        }
    }
}
