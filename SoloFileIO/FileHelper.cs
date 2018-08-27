using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SoloFileIO
{
    public static class FileHelper
    {
        public static void WriteToFile( string path, StringBuilder msg )
        {
            if( !File.Exists( path ) )
            {
                using (StreamWriter buffer = File.CreateText(path))
                {
                    buffer.Write(msg.ToString());
                }
            }
        }

        public static StringBuilder ReadFromFile( string path )
        {
            StringBuilder buffer = new StringBuilder();

            using (StreamReader sr = new StreamReader(path))
            {
                buffer.Append(sr.ReadToEnd());
            }

            return buffer;
        }


        public static void EncryptFile( string path, string password )
        {
            EncryptionHelper.EncryptFile(path, password);
        }
        public static void DecryptFile( string path, string password )
        {
            EncryptionHelper.DecryptFile(path, AppendToFilename(path, ".decrypted"), password );
        }

        public static string AppendToFilename( string filename, string val )
        {
            string ext = System.IO.Path.GetExtension(filename);
            return filename.Substring(0, filename.Length - ext.Length) + val + ext;
        }
    }
}
