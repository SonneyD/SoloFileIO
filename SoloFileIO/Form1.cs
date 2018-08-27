using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoloFileIO
{
    public partial class Form1 : Form
    {
        private string SelectedFile;
        private string pass;

        public Form1()
        {
            InitializeComponent();
            SelectedFile = "";
            pass = "123"; // What is used to encrypt/decrypt file information.
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_browseFile_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();

            if(res == DialogResult.OK)
            {
                SelectedFile = openFileDialog1.FileName;

                txt_SelectedFile.Text = SelectedFile;
            }
        }

        private void txt_SelectedFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            // If we have selected a file
            if (!SelectedFile.Equals(""))
            {
                // Get user input
                if (CreateYesNoDialog("Would you like to encrypt this file?", "Encrypting: " + SelectedFile))
                {
                    FileHelper.EncryptFile(SelectedFile, pass);

                    string outDir = FileHelper.AppendToFilename(SelectedFile, ".aes");

                    // Ask if the user would like to change the selected file
                    if (CreateYesNoDialog("Would you like to switch the selected file to the recently encrypted file?", "Target File: " + outDir))
                    {
                        txt_SelectedFile.Text = outDir;
                        SelectedFile = outDir;
                    }

                }
            }
            else MessageBox.Show("You must select a file first!", "File not selected", MessageBoxButtons.OK);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (!SelectedFile.Equals(""))
            {
                if (CreateYesNoDialog("Would you like to decrypt this file?", "Decrypting: " + SelectedFile))
                {
                    FileHelper.DecryptFile(SelectedFile, pass);

                    string outDir = FileHelper.AppendToFilename(SelectedFile, ".decrypted");

                    if (CreateYesNoDialog("Would you like to switch the selected file to the recently decrypted file?", "Target File: " + outDir))
                    {
                        txt_SelectedFile.Text = outDir;
                        SelectedFile = outDir;
                    }
                }
            }
            else MessageBox.Show("You must select a file first!", "File not selected", MessageBoxButtons.OK);
        }

        private void btn_ViewFile_Click(object sender, EventArgs e)
        {
            if( !SelectedFile.Equals("") )
            {
                Form fileViewer = new FileViewer(System.IO.File.ReadAllLines(SelectedFile));
                fileViewer.Show();
            }
            else
            {
                MessageBox.Show("You must select a file to view first!", "Please select a file first!", MessageBoxButtons.OK);
            }
        }

        /***************************************************************************************/
        private bool CreateYesNoDialog(string arg1, string arg2)
        {
            DialogResult res = MessageBox.Show(arg1, arg2, MessageBoxButtons.YesNoCancel);

            switch (res)
            {
                case DialogResult.Yes:
                    return true;
                case DialogResult.No:
                    return false;

                case DialogResult.Cancel:
                default:
                    return false;
            }
        }
    }
}
