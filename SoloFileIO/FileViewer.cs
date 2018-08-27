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
    public partial class FileViewer : Form
    {

        public FileViewer( string[] fileContents )
        {
            InitializeComponent();

            foreach( string line in fileContents )
            {
                rtxt_FileContents.AppendText(line + "\n");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
