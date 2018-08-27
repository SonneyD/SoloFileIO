namespace SoloFileIO
{
    partial class Form1
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
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_browseFile = new System.Windows.Forms.Button();
            this.txt_SelectedFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ViewFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(12, 89);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(142, 40);
            this.btn_encrypt.TabIndex = 0;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(264, 89);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(142, 40);
            this.btn_decrypt.TabIndex = 1;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_browseFile
            // 
            this.btn_browseFile.Location = new System.Drawing.Point(12, 39);
            this.btn_browseFile.Name = "btn_browseFile";
            this.btn_browseFile.Size = new System.Drawing.Size(84, 23);
            this.btn_browseFile.TabIndex = 2;
            this.btn_browseFile.Text = "Browse Files";
            this.btn_browseFile.UseVisualStyleBackColor = true;
            this.btn_browseFile.Click += new System.EventHandler(this.btn_browseFile_Click);
            // 
            // txt_SelectedFile
            // 
            this.txt_SelectedFile.Location = new System.Drawing.Point(97, 13);
            this.txt_SelectedFile.Name = "txt_SelectedFile";
            this.txt_SelectedFile.ReadOnly = true;
            this.txt_SelectedFile.Size = new System.Drawing.Size(309, 20);
            this.txt_SelectedFile.TabIndex = 3;
            this.txt_SelectedFile.TextChanged += new System.EventHandler(this.txt_SelectedFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected File:";
            // 
            // btn_ViewFile
            // 
            this.btn_ViewFile.Location = new System.Drawing.Point(322, 39);
            this.btn_ViewFile.Name = "btn_ViewFile";
            this.btn_ViewFile.Size = new System.Drawing.Size(84, 23);
            this.btn_ViewFile.TabIndex = 5;
            this.btn_ViewFile.Text = "View File";
            this.btn_ViewFile.UseVisualStyleBackColor = true;
            this.btn_ViewFile.Click += new System.EventHandler(this.btn_ViewFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 141);
            this.Controls.Add(this.btn_ViewFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SelectedFile);
            this.Controls.Add(this.btn_browseFile);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Name = "Form1";
            this.Text = "File Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_browseFile;
        private System.Windows.Forms.TextBox txt_SelectedFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ViewFile;
    }
}

