// Convert BMP To X ////////////////////////////////////////////////////////////////////
// Hi Henri.  This little app will batch convert your BMPs to other formats.  It is
// well commented, but if you have any questions just ask.  There is a little bit of
// validation code, but it will probably crash if you try to feed it files that aren't
// BMPs.  If you like, see if you can make it more error proof.  So you should probably
// make sure the input directory has only BMPs in it.
////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;               // System.Drawing contains the Bitmap class.
using System.Drawing.Imaging;       // System.Drawing.Imaging contains the ImageFormat enumeration.
using System.Text;
using System.Windows.Forms;
using System.IO;                    // System.IO contains in the Directory class.
using System.Diagnostics;           // System.Diagnostics contains the Debug class.

namespace BmpToXConverter
{
    public partial class Form1 : Form
    {
        string outputPath = AppDomain.CurrentDomain.BaseDirectory + "OutputDefault.txt";
        int imageCount = 0;
        
        public Form1()
        {
            InitializeComponent();

            FileStream fs = null;

            if (!File.Exists(outputPath))
            {
                fs = new FileStream(outputPath, FileMode.Create);
                fs.Close();
            }
            else
            {
                // recall output default
                fs = new FileStream(outputPath, FileMode.Open); 
                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    tbOutputDirectory.Text = sr.ReadLine();
                }

                sr.Close();
                fs.Close();
            }

            tbNextNum.Text = imageCount.ToString();
        }

        /*
        // Use the Load event to initialize form components.
        private void Form1_Load(object sender, EventArgs e)
        {
            // recall output default
            FileStream fs = new FileStream(outputPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (sr.Peek() != -1)
            {
                tbOutputDirectory.Text = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }
        */
        
        // This event handler is triggered when the user wants to select an output directory.
        private void btnOutputDirectory_Click(object sender, EventArgs e)
        {
            // Instantiate a new FolderBrowserDialog.
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // Show the dialog and capture the user's interaction, which is in the form of
            // a DialogResult.
            DialogResult dr = fbd.ShowDialog();

            // If the DialogResult is OK, then remember the selected output directory.
            if (dr == DialogResult.OK)
            {
                // Set the text property of the output directory textbox to the selected folder path.
                tbOutputDirectory.Text = fbd.SelectedPath;

                // Inform the use the output directory has been set.
                rtbFeedback.Text += "Output directory set.\n";
            }
            
            FileStream fs = new FileStream(outputPath, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);

            sw.Flush();
            sw.WriteLine(tbOutputDirectory.Text);

            sw.Close();
            fs.Close();

            // If the user does not select the OK button, then exit the event handler without
            // doing anything.
            {
                return;
            }
        }

        // This event is triggered when the user wants to start the conversion process.
        private void btnStart_Click(object sender, EventArgs e)
        {
            string NamePrefix = tbNamePrefix.Text;
            string[] BadChar = new string[9] { "*", "<", ">", "\\", "?", "/", "|", "\"", ":" };

            for (int i = 0; i < BadChar.Length; i++)
            {
                if (SearchString(NamePrefix, BadChar[i]))
                {
                    MessageBox.Show("You cannot have the '" + BadChar[i] + "' character in the name.");
                    return;
                }
            }

            Bitmap bmp1 = null;
            try
            {
                bmp1 = new Bitmap(Clipboard.GetImage());
            }
            catch
            {
                MessageBox.Show("There is no image in the clipboard");
                return;
            }

            try
            {
                bmp1.Save(tbOutputDirectory.Text + "\\" + NamePrefix + imageCount.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                rtbFeedback.Text = NamePrefix + imageCount.ToString() + ".png saved\n" + rtbFeedback.Text;

                imageCount++;
                tbNextNum.Text = imageCount.ToString();
            }
            catch
            {
                MessageBox.Show("Error with saving the image.");
            }
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            Process.Start(tbOutputDirectory.Text);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "Print Screen")
            {
                Process.Start(tbOutputDirectory.Text);
            }
        }

        private void tbNextNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                imageCount = Convert.ToInt32(tbNextNum.Text);
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }

        public bool SearchString(string text, string substring)
        {
            // searches text string for the subtring string and is true if it is found
            if (text != null && substring != null)
            {
                if (text.Length >= substring.Length)
                {
                    for (int a = 0; a <= (text.Length - substring.Length); a++)
                    {
                        if (text.Substring(a, substring.Length) == substring) return true;
                    }
                }
            }

            return false;
        }
    }
}