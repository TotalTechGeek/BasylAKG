using BasylEncryptionStandard.EC;
using BasylEncryptionStandard.RSA;
using BasylEncryptionStandard.GUI;
using BasylEncryptionStandard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BasylAKG
{
    public partial class BasylMainForm : Form
    {

        private AdvancedSettingsForm advForm;
        public BasylMainForm()
        {
            InitializeComponent();
            advForm = new AdvancedSettingsForm();
            this.FormClosing += BasylMainForm_FormClosing;
        }

        private void BasylMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private BasylPseudoAdaptator GetAdaptor()
        {
            BasylPseudoAdaptator adaptor = null;
            if (advForm.GetGenerationMode())
            {
                adaptor = new StrongerBasylPseudoAdaptor(advForm.GetSeedFunction());
            }
            else
            {
                adaptor = new SeedFunctionStringAdaptor(advForm.GetSeedFunction());
            }
            return adaptor;
        }

        private IBasylKeyGenerator GetGeneratorFromUI()
        {
            if (generateFromFileCheckbox.Checked && File.Exists(fileNameTextbox.Text))
            {
               



                return new FileMutatedBKG(new BasylKeyGenerator("BasylKeyGenerationFromFile", advForm.GetInitial(), advForm.GetRounds(), advForm.GetLeftoff(), advForm.GetExpand(), advForm.GetKey(), new byte[32], new byte[4], new byte[4], true, GetAdaptor()), File.OpenRead(fileNameTextbox.Text));
            }

            return CreateGeneratorFromPassword(passwordTextbox.Text);


        }


        private BasylKeyGenerator CreateGeneratorFromPassword(string pass)
        {
            var hashOfPassword = BasylHashAlgorithms.BasylHashUno(pass, "BasylEncryptionStandard_" + pass, pass.Length * 2 + 5, 256 * 256 + pass.Length * 2, 700, 100, "BasylRSA_ECC_" + pass);

            char[] charHash = new char[hashOfPassword.Length];
            byte[] randomizerA = new byte[4];
            byte[] randomizerB = new byte[4];

            int posA = hashOfPassword[0] * hashOfPassword[3] + hashOfPassword[2] * hashOfPassword[1];
            int posB = hashOfPassword[1] * hashOfPassword[0] + hashOfPassword[3] * hashOfPassword[2];

            if (posA == posB) posA += hashOfPassword[4];
            for (int i = 0; i < hashOfPassword.Length; i++)
            {
                charHash[i] = (char)hashOfPassword[i];
                randomizerA[posA++ % 4] ^= hashOfPassword[posA % hashOfPassword.Length];
                randomizerB[posB++ % 4] ^= hashOfPassword[posB % hashOfPassword.Length];
            }

            return new BasylKeyGenerator(new string(charHash) + pass, advForm.GetInitial(), advForm.GetRounds(), advForm.GetLeftoff(), advForm.GetExpand(), advForm.GetKey(), hashOfPassword, randomizerA, randomizerB, true, GetAdaptor());
        }



        private void AddNames(IEnumerable<String> curveList)
        {
            foreach (var curveName in curveList)
            {
                ellipticComboBox.Items.Add(curveName);
            }

        }

        private void BasylMainForm_Load(object sender, EventArgs e)
        {
            
            ellipticComboBox.Sorted = true;
            AddNames(Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Names.Cast<String>());
            AddNames(Org.BouncyCastle.Asn1.X9.X962NamedCurves.Names.Cast<String>());

            AddNames(Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.Names.Cast<String>());
            AddNames(Org.BouncyCastle.Asn1.Nist.NistNamedCurves.Names.Cast<String>());

            ellipticComboBox.SelectedIndex = 0;
        }

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = !showPasswordCheckbox.Checked;

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advForm.Show();
        }

        private void generateRSA_Click(object sender, EventArgs e)
        {
            string pk = (BasylRSAUtilities.GetPrivateKey((new BasylRSAUtilities()).GenerateKeyPair(GetGeneratorFromUI(), (int)numericUpDown1.Value)));
            saveFileDialog.ShowDialog();

            bool possiblePath = saveFileDialog.FileName.IndexOfAny(Path.GetInvalidPathChars()) == -1 && saveFileDialog.FileName.Length != 0;

            if (possiblePath)
                File.WriteAllText(saveFileDialog.FileName, pk);
            saveFileDialog.FileName = "";
        }

        private void generateEC_Click(object sender, EventArgs e)
        {
            string pk = (BasylRSAUtilities.GetPrivateKey(BasylEllipticUtilities.GenerateKeyPair(GetGeneratorFromUI(), ellipticComboBox.SelectedItem.ToString())));
            saveFileDialog.ShowDialog();

            bool possiblePath = saveFileDialog.FileName.IndexOfAny(Path.GetInvalidPathChars()) == -1 && saveFileDialog.FileName.Length != 0;

            if (possiblePath)
                File.WriteAllText(saveFileDialog.FileName, pk);
            saveFileDialog.FileName = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fileNameTextbox.Location = passwordTextbox.Location;
            browseButton.Location = showPasswordCheckbox.Location;
            fileLabel.Location = passwordLabel.Location;

            passwordTextbox.Visible = !generateFromFileCheckbox.Checked;
            fileNameTextbox.Visible = generateFromFileCheckbox.Checked;

            browseButton.Visible = generateFromFileCheckbox.Checked;
            showPasswordCheckbox.Visible = !generateFromFileCheckbox.Checked;

            passwordLabel.Visible = !generateFromFileCheckbox.Checked;
            fileLabel.Visible = generateFromFileCheckbox.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            if (File.Exists(openFileDialog1.FileName))
            {

                fileNameTextbox.Text = openFileDialog1.FileName;
            }

        }

        private void getPublicKeyFromPEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            if (File.Exists(openFileDialog2.FileName))
            {
                var result= BasylRSAUtilities.ReadPrivateKey(File.ReadAllText(openFileDialog2.FileName));
                if (result != null)
                {
                    new PublicKeyPopup(BasylRSAUtilities.GetPublicKey(result)).Show();
                  
                }

            }
        }

        private void getPublicKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "";
            openFileDialog2.DefaultExt = "pem";
            openFileDialog2.Filter = "PEM Files|*.pem";
            openFileDialog2.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an asymmetric key generator. This is useful for generating keys for public key cryptography. One small thing that makes this generator different is the semi-inconsistent key sizes. It allows more flexibility in the generation scheme.");
        }
    }
}
