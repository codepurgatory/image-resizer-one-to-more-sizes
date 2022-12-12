namespace Image_Resizer___One_for_More
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMainImage = new System.Windows.Forms.GroupBox();
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.groupBoxSizes = new System.Windows.Forms.GroupBox();
            this.buttonRemoveSelectedSize = new System.Windows.Forms.Button();
            this.listBoxSizes = new System.Windows.Forms.ListBox();
            this.groupBoxAddSize = new System.Windows.Forms.GroupBox();
            this.buttonAddSize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.buttonStartProccess = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMainStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxMainImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBoxSizes.SuspendLayout();
            this.groupBoxAddSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMainImage
            // 
            this.groupBoxMainImage.Controls.Add(this.buttonChooseImage);
            this.groupBoxMainImage.Controls.Add(this.pictureBoxImage);
            this.groupBoxMainImage.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMainImage.Name = "groupBoxMainImage";
            this.groupBoxMainImage.Size = new System.Drawing.Size(414, 458);
            this.groupBoxMainImage.TabIndex = 0;
            this.groupBoxMainImage.TabStop = false;
            this.groupBoxMainImage.Text = " Main Image";
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseImage.Location = new System.Drawing.Point(6, 425);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(115, 23);
            this.buttonChooseImage.TabIndex = 1;
            this.buttonChooseImage.Text = "Choose image...";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.buttonChooseImage_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // groupBoxSizes
            // 
            this.groupBoxSizes.Controls.Add(this.buttonRemoveSelectedSize);
            this.groupBoxSizes.Controls.Add(this.listBoxSizes);
            this.groupBoxSizes.Location = new System.Drawing.Point(432, 12);
            this.groupBoxSizes.Name = "groupBoxSizes";
            this.groupBoxSizes.Size = new System.Drawing.Size(440, 386);
            this.groupBoxSizes.TabIndex = 1;
            this.groupBoxSizes.TabStop = false;
            this.groupBoxSizes.Text = " Sizes: ";
            // 
            // buttonRemoveSelectedSize
            // 
            this.buttonRemoveSelectedSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveSelectedSize.Location = new System.Drawing.Point(285, 357);
            this.buttonRemoveSelectedSize.Name = "buttonRemoveSelectedSize";
            this.buttonRemoveSelectedSize.Size = new System.Drawing.Size(147, 23);
            this.buttonRemoveSelectedSize.TabIndex = 1;
            this.buttonRemoveSelectedSize.Text = "Remove Selected Size";
            this.buttonRemoveSelectedSize.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedSize.Click += new System.EventHandler(this.buttonRemoveSelectedSize_Click);
            // 
            // listBoxSizes
            // 
            this.listBoxSizes.FormattingEnabled = true;
            this.listBoxSizes.Location = new System.Drawing.Point(6, 19);
            this.listBoxSizes.Name = "listBoxSizes";
            this.listBoxSizes.Size = new System.Drawing.Size(428, 329);
            this.listBoxSizes.TabIndex = 0;
            // 
            // groupBoxAddSize
            // 
            this.groupBoxAddSize.Controls.Add(this.buttonAddSize);
            this.groupBoxAddSize.Controls.Add(this.label2);
            this.groupBoxAddSize.Controls.Add(this.numericUpDownHeight);
            this.groupBoxAddSize.Controls.Add(this.label1);
            this.groupBoxAddSize.Controls.Add(this.numericUpDownWidth);
            this.groupBoxAddSize.Controls.Add(this.labelWidth);
            this.groupBoxAddSize.Location = new System.Drawing.Point(432, 404);
            this.groupBoxAddSize.Name = "groupBoxAddSize";
            this.groupBoxAddSize.Size = new System.Drawing.Size(440, 66);
            this.groupBoxAddSize.TabIndex = 2;
            this.groupBoxAddSize.TabStop = false;
            this.groupBoxAddSize.Text = " Add Size: ";
            // 
            // buttonAddSize
            // 
            this.buttonAddSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSize.Location = new System.Drawing.Point(357, 31);
            this.buttonAddSize.Name = "buttonAddSize";
            this.buttonAddSize.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSize.TabIndex = 6;
            this.buttonAddSize.Text = "Add";
            this.buttonAddSize.UseVisualStyleBackColor = true;
            this.buttonAddSize.Click += new System.EventHandler(this.buttonAddSize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(188, 34);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(163, 20);
            this.numericUpDownHeight.TabIndex = 4;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height:";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(7, 34);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(155, 20);
            this.numericUpDownWidth.TabIndex = 2;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(4, 18);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 1;
            this.labelWidth.Text = "Width:";
            // 
            // buttonStartProccess
            // 
            this.buttonStartProccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartProccess.Location = new System.Drawing.Point(698, 476);
            this.buttonStartProccess.Name = "buttonStartProccess";
            this.buttonStartProccess.Size = new System.Drawing.Size(174, 45);
            this.buttonStartProccess.TabIndex = 3;
            this.buttonStartProccess.Text = "Resize image to all sizes";
            this.buttonStartProccess.UseVisualStyleBackColor = true;
            this.buttonStartProccess.Click += new System.EventHandler(this.buttonStartProccess_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMainStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMainStatus
            // 
            this.toolStripStatusLabelMainStatus.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabelMainStatus.Name = "toolStripStatusLabelMainStatus";
            this.toolStripStatusLabelMainStatus.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabelMainStatus.Text = "Status...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonStartProccess);
            this.Controls.Add(this.groupBoxAddSize);
            this.Controls.Add(this.groupBoxSizes);
            this.Controls.Add(this.groupBoxMainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Resizer - One for More";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxMainImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBoxSizes.ResumeLayout(false);
            this.groupBoxAddSize.ResumeLayout(false);
            this.groupBoxAddSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMainImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonChooseImage;
        private System.Windows.Forms.GroupBox groupBoxSizes;
        private System.Windows.Forms.Button buttonRemoveSelectedSize;
        private System.Windows.Forms.ListBox listBoxSizes;
        private System.Windows.Forms.GroupBox groupBoxAddSize;
        private System.Windows.Forms.Button buttonAddSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Button buttonStartProccess;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMainStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

