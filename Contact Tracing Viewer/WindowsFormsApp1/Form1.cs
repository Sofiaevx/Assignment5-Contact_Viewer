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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        StreamReader readeroutputfile;
        String currentline;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            string location = @"D:\This PC\Desktop\OutputFile\" + textBoxLN.Text + ", " + textBoxFN.Text + ".txt";
            

            if (File.Exists(location))
            {
                currentline = File.ReadAllText(location);
                richTextBoxDisplay.Text = currentline;
            }
            else
            {
                richTextBoxDisplay.Text = "TextFile Not Found";
            }
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            textBoxLN.Text = "";
            textBoxFN.Text = "";
            richTextBoxDisplay.Text = "";
        }
    }
}
