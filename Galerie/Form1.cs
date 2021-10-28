using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galerie
{
    public partial class Form1 : Form
    {
        List<String> images = null;
        int bildIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLadeBilder_Click(object sender, EventArgs e)
        {
            ImportiereBilder();
        }

        private void ImportiereBilder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                images = GetImagesPath(folderBrowserDialog1.SelectedPath);
                pictureBox1.ImageLocation = images[0];
            }
        }

        private List<String> GetImagesPath(String folderName)
        {

            DirectoryInfo Folder;
            FileInfo[] Images;

            Folder = new DirectoryInfo(folderName);
            Images = Folder.GetFiles();
            List<String> imagesList = new List<String>();

            for (int i = 0; i < Images.Length; i++)
            {
                imagesList.Add(String.Format(@"{0}/{1}", folderName, Images[i].Name));
                // Console.WriteLine(String.Format(@"{0}/{1}", folderName, Images[i].Name));
            }


            return imagesList;
        }

        private void buttonVorheriges_Click(object sender, EventArgs e)
        {
            bildIndex--;
            if (bildIndex < 0)
            {
                bildIndex = images.Count - 1;
            }
            ShowImage();
        }

        private void buttonNächtes_Click(object sender, EventArgs e)
        {
            bildIndex++;
            if (bildIndex == images.Count)
            {
                bildIndex = 0;
            }
            ShowImage();
        }

        private void ShowImage()
        {
            pictureBox1.ImageLocation = images[bildIndex];
        }

        private void importierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportiereBilder();
        }
    }
}
