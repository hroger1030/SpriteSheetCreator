namespace SpriteSheetTool
{
    partial class SpriteSheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteSheetForm));
            this.btnBuildSpriteSheet = new System.Windows.Forms.Button();
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.cboMaskColor = new System.Windows.Forms.ComboBox();
            this.lblMaskColor = new System.Windows.Forms.Label();
            this.gbMask = new System.Windows.Forms.GroupBox();
            this.cboBackgroundColor = new System.Windows.Forms.ComboBox();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.btnClearAllFiles = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnCalculateDimensions = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtFileCount = new System.Windows.Forms.TextBox();
            this.gbOutputOptions = new System.Windows.Forms.GroupBox();
            this.lblOutputType = new System.Windows.Forms.Label();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.lblOutputFilename = new System.Windows.Forms.Label();
            this.btnSelectOutputDirectory = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.gbDimensions = new System.Windows.Forms.GroupBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnDisassembleSpriteSheet = new System.Windows.Forms.Button();
            this.lblReorder = new System.Windows.Forms.Label();
            this.btnSortFiles = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.gbMask.SuspendLayout();
            this.gbOutputOptions.SuspendLayout();
            this.gbDimensions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuildSpriteSheet
            // 
            this.btnBuildSpriteSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildSpriteSheet.Location = new System.Drawing.Point(449, 492);
            this.btnBuildSpriteSheet.Name = "btnBuildSpriteSheet";
            this.btnBuildSpriteSheet.Size = new System.Drawing.Size(117, 23);
            this.btnBuildSpriteSheet.TabIndex = 0;
            this.btnBuildSpriteSheet.Text = "Build SpriteSheet";
            this.btnBuildSpriteSheet.UseVisualStyleBackColor = true;
            this.btnBuildSpriteSheet.Click += new System.EventHandler(this.btnBuildSpriteSheet_Click);
            // 
            // lbxFiles
            // 
            this.lbxFiles.AllowDrop = true;
            this.lbxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.Location = new System.Drawing.Point(12, 29);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(554, 212);
            this.lbxFiles.TabIndex = 1;
            this.lbxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxFiles_DragDrop);
            this.lbxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbxFiles_DragEnter);
            this.lbxFiles.DragLeave += new System.EventHandler(this.lbxFiles_DragLeave);
            this.lbxFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxFiles_OnKeyDown);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(12, 13);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 2;
            this.lblFiles.Text = "Files:";
            // 
            // cboMaskColor
            // 
            this.cboMaskColor.FormattingEnabled = true;
            this.cboMaskColor.Location = new System.Drawing.Point(106, 28);
            this.cboMaskColor.Name = "cboMaskColor";
            this.cboMaskColor.Size = new System.Drawing.Size(197, 21);
            this.cboMaskColor.TabIndex = 6;
            // 
            // lblMaskColor
            // 
            this.lblMaskColor.AutoSize = true;
            this.lblMaskColor.Location = new System.Drawing.Point(40, 31);
            this.lblMaskColor.Name = "lblMaskColor";
            this.lblMaskColor.Size = new System.Drawing.Size(60, 13);
            this.lblMaskColor.TabIndex = 7;
            this.lblMaskColor.Text = "Mask Color";
            // 
            // gbMask
            // 
            this.gbMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMask.Controls.Add(this.cboBackgroundColor);
            this.gbMask.Controls.Add(this.lblBackgroundColor);
            this.gbMask.Controls.Add(this.cboMaskColor);
            this.gbMask.Controls.Add(this.lblMaskColor);
            this.gbMask.Location = new System.Drawing.Point(250, 274);
            this.gbMask.Name = "gbMask";
            this.gbMask.Size = new System.Drawing.Size(316, 91);
            this.gbMask.TabIndex = 15;
            this.gbMask.TabStop = false;
            this.gbMask.Text = "Image Colors";
            // 
            // cboBackgroundColor
            // 
            this.cboBackgroundColor.FormattingEnabled = true;
            this.cboBackgroundColor.Location = new System.Drawing.Point(106, 57);
            this.cboBackgroundColor.Name = "cboBackgroundColor";
            this.cboBackgroundColor.Size = new System.Drawing.Size(197, 21);
            this.cboBackgroundColor.TabIndex = 9;
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(8, 60);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(92, 13);
            this.lblBackgroundColor.TabIndex = 8;
            this.lblBackgroundColor.Text = "Background Color";
            // 
            // btnClearAllFiles
            // 
            this.btnClearAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAllFiles.Location = new System.Drawing.Point(93, 492);
            this.btnClearAllFiles.Name = "btnClearAllFiles";
            this.btnClearAllFiles.Size = new System.Drawing.Size(96, 23);
            this.btnClearAllFiles.TabIndex = 17;
            this.btnClearAllFiles.Text = "Clear All Files";
            this.btnClearAllFiles.UseVisualStyleBackColor = true;
            this.btnClearAllFiles.Click += new System.EventHandler(this.btnClearAllFiles_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(56, 28);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(44, 20);
            this.txtWidth.TabIndex = 9;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(56, 57);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(44, 20);
            this.txtHeight.TabIndex = 10;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(15, 60);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 13;
            this.lblHeight.Text = "Height";
            // 
            // btnCalculateDimensions
            // 
            this.btnCalculateDimensions.Location = new System.Drawing.Point(115, 26);
            this.btnCalculateDimensions.Name = "btnCalculateDimensions";
            this.btnCalculateDimensions.Size = new System.Drawing.Size(96, 23);
            this.btnCalculateDimensions.TabIndex = 11;
            this.btnCalculateDimensions.Text = "Auto Calculate";
            this.btnCalculateDimensions.UseVisualStyleBackColor = true;
            this.btnCalculateDimensions.Click += new System.EventHandler(this.btnCalculateDimensions_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(18, 31);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 12;
            this.lblWidth.Text = "Width";
            // 
            // txtFileCount
            // 
            this.txtFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFileCount.Location = new System.Drawing.Point(69, 249);
            this.txtFileCount.Name = "txtFileCount";
            this.txtFileCount.ReadOnly = true;
            this.txtFileCount.Size = new System.Drawing.Size(39, 20);
            this.txtFileCount.TabIndex = 14;
            // 
            // gbOutputOptions
            // 
            this.gbOutputOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbOutputOptions.Controls.Add(this.lblOutputType);
            this.gbOutputOptions.Controls.Add(this.cboFileType);
            this.gbOutputOptions.Controls.Add(this.txtOutputDirectory);
            this.gbOutputOptions.Controls.Add(this.lblOutputFilename);
            this.gbOutputOptions.Controls.Add(this.btnSelectOutputDirectory);
            this.gbOutputOptions.Controls.Add(this.txtOutputFile);
            this.gbOutputOptions.Controls.Add(this.lblOutputDirectory);
            this.gbOutputOptions.Location = new System.Drawing.Point(15, 371);
            this.gbOutputOptions.Name = "gbOutputOptions";
            this.gbOutputOptions.Size = new System.Drawing.Size(551, 115);
            this.gbOutputOptions.TabIndex = 16;
            this.gbOutputOptions.TabStop = false;
            this.gbOutputOptions.Text = "Output Options";
            // 
            // lblOutputType
            // 
            this.lblOutputType.AutoSize = true;
            this.lblOutputType.Location = new System.Drawing.Point(15, 82);
            this.lblOutputType.Name = "lblOutputType";
            this.lblOutputType.Size = new System.Drawing.Size(85, 13);
            this.lblOutputType.TabIndex = 9;
            this.lblOutputType.Text = "Output File Type";
            // 
            // cboFileType
            // 
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Location = new System.Drawing.Point(105, 79);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(124, 21);
            this.cboFileType.TabIndex = 8;
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Location = new System.Drawing.Point(105, 53);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(435, 20);
            this.txtOutputDirectory.TabIndex = 7;
            // 
            // lblOutputFilename
            // 
            this.lblOutputFilename.AutoSize = true;
            this.lblOutputFilename.Location = new System.Drawing.Point(11, 30);
            this.lblOutputFilename.Name = "lblOutputFilename";
            this.lblOutputFilename.Size = new System.Drawing.Size(89, 13);
            this.lblOutputFilename.TabIndex = 6;
            this.lblOutputFilename.Text = "Output File Name";
            // 
            // btnSelectOutputDirectory
            // 
            this.btnSelectOutputDirectory.Location = new System.Drawing.Point(434, 82);
            this.btnSelectOutputDirectory.Name = "btnSelectOutputDirectory";
            this.btnSelectOutputDirectory.Size = new System.Drawing.Size(106, 23);
            this.btnSelectOutputDirectory.TabIndex = 5;
            this.btnSelectOutputDirectory.Text = "Change Directory";
            this.btnSelectOutputDirectory.UseVisualStyleBackColor = true;
            this.btnSelectOutputDirectory.Click += new System.EventHandler(this.btnSelectOutputDirectory_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.AcceptsTab = true;
            this.txtOutputFile.Location = new System.Drawing.Point(105, 27);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(435, 20);
            this.txtOutputFile.TabIndex = 3;
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Location = new System.Drawing.Point(16, 56);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(84, 13);
            this.lblOutputDirectory.TabIndex = 4;
            this.lblOutputDirectory.Text = "Output Directory";
            // 
            // lblFileCount
            // 
            this.lblFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(14, 252);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(54, 13);
            this.lblFileCount.TabIndex = 15;
            this.lblFileCount.Text = "File Count";
            // 
            // gbDimensions
            // 
            this.gbDimensions.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDimensions.Controls.Add(this.btnReverse);
            this.gbDimensions.Controls.Add(this.lblWidth);
            this.gbDimensions.Controls.Add(this.btnCalculateDimensions);
            this.gbDimensions.Controls.Add(this.lblHeight);
            this.gbDimensions.Controls.Add(this.txtHeight);
            this.gbDimensions.Controls.Add(this.txtWidth);
            this.gbDimensions.Location = new System.Drawing.Point(15, 274);
            this.gbDimensions.Name = "gbDimensions";
            this.gbDimensions.Size = new System.Drawing.Size(229, 91);
            this.gbDimensions.TabIndex = 14;
            this.gbDimensions.TabStop = false;
            this.gbDimensions.Text = "Sprite Sheet Output Dimensions";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(115, 55);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(96, 23);
            this.btnReverse.TabIndex = 14;
            this.btnReverse.Text = "Invert Values";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnDisassembleSpriteSheet
            // 
            this.btnDisassembleSpriteSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisassembleSpriteSheet.Location = new System.Drawing.Point(297, 492);
            this.btnDisassembleSpriteSheet.Name = "btnDisassembleSpriteSheet";
            this.btnDisassembleSpriteSheet.Size = new System.Drawing.Size(146, 23);
            this.btnDisassembleSpriteSheet.TabIndex = 18;
            this.btnDisassembleSpriteSheet.Text = "Disassemble SpriteSheet";
            this.btnDisassembleSpriteSheet.UseVisualStyleBackColor = true;
            this.btnDisassembleSpriteSheet.Click += new System.EventHandler(this.btnDisassembleSpriteSheet_Click);
            // 
            // lblReorder
            // 
            this.lblReorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReorder.AutoSize = true;
            this.lblReorder.Location = new System.Drawing.Point(415, 13);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(151, 13);
            this.lblReorder.TabIndex = 19;
            this.lblReorder.Text = "(Q and A will move items in list)";
            // 
            // btnSortFiles
            // 
            this.btnSortFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortFiles.Location = new System.Drawing.Point(195, 492);
            this.btnSortFiles.Name = "btnSortFiles";
            this.btnSortFiles.Size = new System.Drawing.Size(96, 23);
            this.btnSortFiles.TabIndex = 20;
            this.btnSortFiles.Text = "Sort Files";
            this.btnSortFiles.UseVisualStyleBackColor = true;
            this.btnSortFiles.Click += new System.EventHandler(this.btnSortFiles_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(171, 252);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(395, 16);
            this.pbProgress.TabIndex = 21;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(117, 252);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 22;
            this.lblProgress.Text = "Progress";
            // 
            // SpriteSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 527);
            this.Controls.Add(this.txtFileCount);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnSortFiles);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.btnDisassembleSpriteSheet);
            this.Controls.Add(this.btnClearAllFiles);
            this.Controls.Add(this.gbOutputOptions);
            this.Controls.Add(this.gbMask);
            this.Controls.Add(this.gbDimensions);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lbxFiles);
            this.Controls.Add(this.btnBuildSpriteSheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(588, 488);
            this.Name = "SpriteSheetForm";
            this.Text = "Load Error";
            this.gbMask.ResumeLayout(false);
            this.gbMask.PerformLayout();
            this.gbOutputOptions.ResumeLayout(false);
            this.gbOutputOptions.PerformLayout();
            this.gbDimensions.ResumeLayout(false);
            this.gbDimensions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuildSpriteSheet;
        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.ComboBox cboMaskColor;
        private System.Windows.Forms.Label lblMaskColor;
        private System.Windows.Forms.GroupBox gbMask;
        private System.Windows.Forms.Button btnClearAllFiles;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.ComboBox cboBackgroundColor;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnCalculateDimensions;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtFileCount;
        private System.Windows.Forms.GroupBox gbOutputOptions;
        private System.Windows.Forms.Label lblOutputType;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.Label lblOutputFilename;
        private System.Windows.Forms.Button btnSelectOutputDirectory;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.GroupBox gbDimensions;
        private System.Windows.Forms.Button btnDisassembleSpriteSheet;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.Button btnSortFiles;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnReverse;
    }
}

