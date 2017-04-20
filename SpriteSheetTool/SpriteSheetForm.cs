using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using ImageManipulation;

namespace SpriteSheetTool
{
    public partial class SpriteSheetForm : Form
    {
        protected List<cImage> _ImageList;
        protected Point _ImagePattern;

        private void lbxFiles_OnKeyDown(object sender, KeyEventArgs e)
        {
            // delete attempt
            if ((e.KeyCode == Keys.Delete) && (lbxFiles.SelectedIndex != -1))
            {
                int file_index = this.lbxFiles.SelectedIndex;

                this.lbxFiles.Items.RemoveAt(file_index);
                _ImageList.RemoveAt(file_index);
                this.txtFileCount.Text = _ImageList.Count.ToString();

                ResetProgressbar(_ImageList.Count);
            }

            // Move item up
            if ((e.KeyCode == Keys.Q) && (lbxFiles.SelectedIndex != -1) && (lbxFiles.SelectedIndex != 0))
            {
                int index = this.lbxFiles.SelectedIndex;
                cImage image = _ImageList[index];

                _ImageList.RemoveAt(index);

                _ImageList.Insert(index - 1, image);

                this.lbxFiles.Items.Clear();

                foreach (cImage item in _ImageList)
                {
                    this.lbxFiles.Items.Add(item.Filename);
                }

                lbxFiles.SelectedIndex = index - 1;

                ResetProgressbar(_ImageList.Count);
            }

            // Move item down
            if ((e.KeyCode == Keys.A) && (lbxFiles.SelectedIndex != -1) && (lbxFiles.SelectedIndex != lbxFiles.Items.Count - 1))
            {
                int index = this.lbxFiles.SelectedIndex;
                cImage image = _ImageList[index];

                _ImageList.RemoveAt(index);

                _ImageList.Insert(index + 1, image);

                this.lbxFiles.Items.Clear();

                foreach (cImage item in _ImageList)
                {
                    this.lbxFiles.Items.Add(item.Filename);
                }

                lbxFiles.SelectedIndex = index + 1;

                ResetProgressbar(_ImageList.Count);
            }
        }
        private void lbxFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void lbxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] file_name_list = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file_name in file_name_list)
            {
                //ImageFormat foo 
                if (IsImageAKnownType(file_name) && !lbxFiles.Items.Contains(file_name))
                {
                    this.lbxFiles.Items.Add(file_name);

                    FileStream input_stream = new FileStream(file_name, FileMode.Open);
                    Bitmap bitmap = new Bitmap(input_stream);
                    input_stream.Close();

                    this._ImageList.Add(new cImage(file_name, bitmap));

                    List<Bitmap> image_list = new List<Bitmap>();
                    foreach (var item in _ImageList)
                        image_list.Add(item.Image);

                    if (!SpriteSheet.AreAllImagesSameSize(image_list))
                    {
                        MessageBox.Show("You just added an image that wasn't the same size as the other images in the list. If you do this, you may get odd results.",
                            "Non-standard size image", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                }
            }

            this.txtFileCount.Text = lbxFiles.Items.Count.ToString();
            ResetProgressbar(_ImageList.Count);
        }
        private void lbxFiles_DragLeave(object sender, EventArgs e)
        {
            // to do : remove files?
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            _ImagePattern.X = Convert.ToInt32(this.txtWidth.Text);
        }
        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            _ImagePattern.Y = Convert.ToInt32(this.txtHeight.Text);
        }
        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void btnBuildSpriteSheet_Click(object sender, EventArgs e)
        {
            if (this._ImageList.Count == 0)
                return;

            if ((_ImagePattern.X * _ImagePattern.Y) == 0)
            {
                CalcSpriteSheetDimensions();

                if ((_ImagePattern.X * _ImagePattern.Y) == 0)
                {
                    MessageBox.Show("Cannot automatically calculate correct image output arrangement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // if there is no filename selected, use the name of the first item
            string output_file_name;

            if (this.txtOutputFile.Text != string.Empty)
                output_file_name = this.txtOutputFile.Text;
            else
                output_file_name = Path.GetFileNameWithoutExtension(_ImageList[0].Filename);

            string output_directory = this.txtOutputDirectory.Text;

            KnownColor background_color = (KnownColor)Enum.Parse(typeof(KnownColor), this.cboBackgroundColor.SelectedItem.ToString());
            KnownColor mask_color = (KnownColor)Enum.Parse(typeof(KnownColor), this.cboMaskColor.SelectedItem.ToString());

            string image_format = (string)this.cboFileType.SelectedItem;

            List<string> image_list = new List<string>();

            foreach (cImage item in _ImageList)
                image_list.Add(item.Filename);

            // setup progress bar
            ResetProgressbar(_ImageList.Count);
            SpriteSheet.UpdateProgressBar update_progress_bar = new SpriteSheet.UpdateProgressBar(UpdateProgressbar);

            if (!SpriteSheet.CreateSpriteSheet(image_list, _ImagePattern, background_color, mask_color, output_file_name, output_directory, image_format, update_progress_bar))
            {
                DisplayMessage("Errors occured during processing.");
                this.pbProgress.ForeColor = Color.Red;
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                this.pbProgress.ForeColor = Color.Green;
            }
        }
        private void btnDisassembleSpriteSheet_Click(object sender, EventArgs e)
        {
            if ((_ImagePattern.X * _ImagePattern.Y) == 0)
            {
                DisplayMessage("You haven't set the output image pattern yet. Enter it, or press the 'Auto Calculate button.");
                return;
            }

            string image_format = (string)this.cboFileType.SelectedItem;
            string output_directory = this.txtOutputDirectory.Text;

            SpriteSheet.UpdateProgressBar update_progress_bar = new SpriteSheet.UpdateProgressBar(UpdateProgressbar);

            foreach (cImage item in _ImageList)
            {
                this.lbxFiles.SelectedItem = item.Filename;

                ResetProgressbar(_ImagePattern.X * _ImagePattern.Y);

                string output_file_name = item.Filename.Substring(item.Filename.LastIndexOf('\\') + 1);
                output_file_name = output_file_name.Substring(0, output_file_name.IndexOf('.'));

                if (!SpriteSheet.SeperateSpriteSheet(item.Filename, _ImagePattern, output_file_name, output_directory, image_format, update_progress_bar))
                {
                    DisplayMessage("Errors occured during processing.");
                    this.pbProgress.ForeColor = Color.Red;
                    return;
                }
            }

            System.Media.SystemSounds.Asterisk.Play();
            this.pbProgress.ForeColor = Color.Green;
        }
        private void btnSelectOutputDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_browser = new FolderBrowserDialog();
            folder_browser.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult result = folder_browser.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.txtOutputDirectory.Text = folder_browser.SelectedPath;
            }
        }
        private void btnClearAllFiles_Click(object sender, EventArgs e)
        {
            ResetProgressbar(_ImageList.Count);
            ResetImageList();
            ResetImagePattern();
        }
        private void btnCalculateDimensions_Click(object sender, EventArgs e)
        {
            CalcSpriteSheetDimensions();
        }
        private void btnSortFiles_Click(object sender, EventArgs e)
        {
            _ImageList = (from item in _ImageList orderby item.Filename select item).ToList();

            this.lbxFiles.Items.Clear();

            foreach (cImage item in _ImageList)
                this.lbxFiles.Items.Add(item.Filename);

            ResetProgressbar(_ImageList.Count);
        }
        private void btnReverse_Click(object sender, EventArgs e)
        {
            Point buffer = _ImagePattern;

            _ImagePattern.X = buffer.Y;
            _ImagePattern.Y = buffer.X;

            this.txtHeight.Text = _ImagePattern.Y.ToString();
            this.txtWidth.Text = _ImagePattern.X.ToString();
        }

        public SpriteSheetForm()
        {
            InitializeComponent();

            // Get file version from assembly info
            System.Diagnostics.FileVersionInfo file_info = System.Diagnostics.FileVersionInfo.GetVersionInfo("SpriteSheetTool.exe");
            this.Text = "SpriteSheet Tool V" + file_info.FileVersion;

            BindData();
            ResetImageList();
            ResetImagePattern();

            this.txtOutputDirectory.Text = Directory.GetCurrentDirectory();
        }

        public void UpdateProgressbar()
        {
            this.pbProgress.Value++;
        }
        public void ResetProgressbar(int max_value)
        {
            this.pbProgress.Minimum = 0;
            this.pbProgress.Maximum = max_value;
            this.pbProgress.Value = 0;
            this.pbProgress.ForeColor = Color.Blue;
        }

        private void BindData()
        {
            // Color mask
            this.cboMaskColor.Items.Clear();
            this.cboMaskColor.DataSource = SpriteSheet.ColorList;
            this.cboMaskColor.SelectedItem = "Black";

            // Background color
            this.cboBackgroundColor.Items.Clear();
            this.cboBackgroundColor.DataSource = SpriteSheet.ColorList;
            this.cboBackgroundColor.SelectedIndex = 0;

            // File types
            this.cboFileType.Items.Clear();
            this.cboFileType.DataSource = SpriteSheet.SupportedFormatsList;
            this.cboFileType.SelectedItem = "Png";
        }
        private void CalcSpriteSheetDimensions()
        {
            Point size;

            if (_ImageList.Count == 0)
            {
                size = new Point();
            }
            else
            {
                List<Bitmap> image_list = new List<Bitmap>();

                foreach (var item in _ImageList)
                    image_list.Add(item.Image);

                size = SpriteSheet.CalculateSpriteSheetOrganization(this.lbxFiles.Items.Count, SpriteSheet.GetLargestImageDimensions(image_list));
            }

            this.txtWidth.Text = size.X.ToString();
            this.txtHeight.Text = size.Y.ToString();
        }
        private bool IsImageAKnownType(string file_name)
        {
            string file_extension_type = file_name.Substring(file_name.LastIndexOf('.')).ToLower();

            string[] known_images = { ".bmp", ".png", ".gif", ".jpg" };
            List<string> images = new List<string>(known_images);

            if (images.Contains(file_extension_type))
            {
                return true;
            }

            return false;
        }
        private void ResetImageList()
        {
            _ImageList = new List<cImage>();

            this.lbxFiles.Items.Clear();
            ResetImagePattern();
        }
        private void ResetImagePattern()
        {
            _ImagePattern = new Point(0, 0);

            this.txtWidth.Text = _ImagePattern.X.ToString();
            this.txtHeight.Text = _ImagePattern.Y.ToString();
        }
        private void DisplayMessage(string message)
        {
            MessageBox.Show(message, "CAN I HAZ UR ATTENSHUN?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
