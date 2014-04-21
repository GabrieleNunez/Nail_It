using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace Nail_It
{
    public partial class NailItForm : Form
    {
        public NailItForm()
        {
            InitializeComponent();
        }

        private void inputBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                inputTextBox.Text = folderBrowserDialog.SelectedPath;

            }
        }

        private void outputBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string[] files = Directory.GetFiles(inputTextBox.Text);
            
            int maxWidth = (int)maxWidthNumeric.Value;
            int maxHeight = (int)maxHeightNumeric.Value;
            
            foreach (string file in files)
            {
                try
                {
                    Image image = Image.FromFile(file);

                    int width = image.Width;
                    int height = image.Height;

                    float diffX = (float)maxWidth / (float)width;
                    float diffY = (float)maxHeight / (float)height;
                    
                    float aspectRatio = diffY < diffX ? diffY : diffX;
                    
                    int newWidth = (int)((width * aspectRatio));
                    int newHeight = (int)((height * aspectRatio));

                    Bitmap bitmap = new Bitmap(newWidth, newHeight);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(image, 0, 0, newWidth, newHeight);

                    ImageFormat imgFormat = ImageFormat.Jpeg;
                    switch (Path.GetExtension(file).ToLower())
                    {
                        case ".jpeg":
                        case ".jpg":
                            imgFormat = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            imgFormat = ImageFormat.Png;
                            break;
                        case ".gif":
                            imgFormat = ImageFormat.Gif;
                            break;
                        default:
                            imgFormat  = ImageFormat.Bmp;
                            break;
                    }
                    bitmap.Save(Path.Combine(outputTextBox.Text, Path.GetFileName(file)), imgFormat);

                    graphics.Dispose();
                    bitmap.Dispose();
                    image.Dispose();
                }
                catch { }
               
            }
            this.Cursor = Cursors.Arrow;
        }
    }
}
