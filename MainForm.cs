using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Resizer___One_for_More
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                pictureBoxImage.Load(openFileDialog.FileName);

                if (!Directory.Exists("Temp"))
                {
                    Directory.CreateDirectory("Temp");
                }

                pictureBoxImage.Image.Save(@"Temp\original.jpg");

                buttonStartProccess.Enabled = true;
            }
            else
            {
                MessageBox.Show("File not selected!");
            }
        }

        private void buttonRemoveSelectedSize_Click(object sender, EventArgs e)
        {
            if(listBoxSizes.Items.Count > 0)
            {
                if(listBoxSizes.SelectedIndex < listBoxSizes.Items.Count)
                {
                    listBoxSizes.Items.Remove(listBoxSizes.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Some error...!");
                }
            }
            else
            {
                MessageBox.Show("Nothing to remove!");
            }
        }


        private void buttonStartProccess_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            foreach (string sizeString in listBoxSizes.Items)
            {
                string[] spArray = sizeString.Split('x');
                int width = Int32.Parse(spArray[0]);
                int height = Int32.Parse(spArray[1]);

                Image img = (Image)(new Bitmap(pictureBoxImage.Image, new Size(width, height)));
                img.Save($@"Temp\{width}x{height}.jpg");
            }
            sw.Stop();
            MessageBox.Show($"Done! At {sw.ElapsedMilliseconds} ms.");
        }

        private void buttonAddSize_Click(object sender, EventArgs e)
        {
            string item = $@"{numericUpDownWidth.Value}x{numericUpDownHeight.Value}";

            bool flagIsset = false;

            foreach (string lstItem in listBoxSizes.Items)
            {
                if(item == lstItem)
                {
                    flagIsset = true; break;
                }
            }

            if (flagIsset)
            {
                MessageBox.Show("Size exists!");
            }
            else
            {
                listBoxSizes.Items.Add(item);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listBoxSizes.Items.Add("1024x1024");
            listBoxSizes.Items.Add("512x512");
            listBoxSizes.Items.Add("432x432");
            listBoxSizes.Items.Add("324x324");
            listBoxSizes.Items.Add("256x256");
            listBoxSizes.Items.Add("216x216");
            listBoxSizes.Items.Add("200x200");
            listBoxSizes.Items.Add("192x192");
            listBoxSizes.Items.Add("162x162");
            listBoxSizes.Items.Add("150x150");
            listBoxSizes.Items.Add("144x144");
            listBoxSizes.Items.Add("128x128");
            listBoxSizes.Items.Add("108x108");
            listBoxSizes.Items.Add("100x100");
            listBoxSizes.Items.Add("96x96");
            listBoxSizes.Items.Add("81x81");
            listBoxSizes.Items.Add("75x75");
            listBoxSizes.Items.Add("72x72");
            listBoxSizes.Items.Add("71x71");
            listBoxSizes.Items.Add("64x64");
            listBoxSizes.Items.Add("63x63");
            listBoxSizes.Items.Add("50x50");
            listBoxSizes.Items.Add("48x48");
            listBoxSizes.Items.Add("36x36");
            listBoxSizes.Items.Add("32x32");
            listBoxSizes.Items.Add("16x16");
            buttonStartProccess.Enabled = false;
        }
    }
}
