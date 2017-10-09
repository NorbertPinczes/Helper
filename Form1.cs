using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JsonSerializerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadJson_Click(object sender, EventArgs e)
        {
            //step 1 open file location
            //step 2 select json file
            //step 3 open json file

            string filePath = "";

            DialogResult dResult = openJsonFileDialog.ShowDialog();
            if (dResult == DialogResult.OK)
                filePath = openJsonFileDialog.FileName;
            //empty path can be an issue

            try
            {
                ReadJsonFile(filePath);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ReadJsonFile(string path)
        {
            //Open the file              
            var stream = File.OpenText(path);
            //Read the file              
            string st = stream.ReadToEnd();

            DisplayJson.Text = st;
        }
    }
}
