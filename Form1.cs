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

namespace CatchingExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open and read the first two lines of \"party list.txt\"");
            // create the input stream and open file called "party list.txt" 
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("party-list.txt");
                // read the first two lines and show them
                string lines = "";
                lines += inputFile.ReadLine() + "\n";
                lines += inputFile.ReadLine() + "\n";
                MessageBox.Show(lines);
                // close the stream/file
                inputFile.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Error opening or reading the file.\n\n" + ex);
            }
        }
    }
}
