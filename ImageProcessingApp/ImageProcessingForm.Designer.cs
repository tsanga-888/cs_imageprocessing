
namespace ImageProcessingApp
{
    partial class ImageProcessingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InputImageBox = new System.Windows.Forms.PictureBox();
            this.OutputImageBox = new System.Windows.Forms.PictureBox();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButtonOriginal = new System.Windows.Forms.RadioButton();
            this.radioButtonGrayscale = new System.Windows.Forms.RadioButton();
            this.radioButtonBlackAndWhite = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelnput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(43, 273);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(111, 23);
            this.LoadFileButton.TabIndex = 0;
            this.LoadFileButton.Text = "Load Image";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(423, 273);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(111, 23);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.Text = "Save Image";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // InputImageBox
            // 
            this.InputImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputImageBox.Location = new System.Drawing.Point(42, 52);
            this.InputImageBox.Name = "InputImageBox";
            this.InputImageBox.Size = new System.Drawing.Size(354, 214);
            this.InputImageBox.TabIndex = 2;
            this.InputImageBox.TabStop = false;
            // 
            // OutputImageBox
            // 
            this.OutputImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputImageBox.Location = new System.Drawing.Point(423, 52);
            this.OutputImageBox.Name = "OutputImageBox";
            this.OutputImageBox.Size = new System.Drawing.Size(354, 214);
            this.OutputImageBox.TabIndex = 3;
            this.OutputImageBox.TabStop = false;
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Location = new System.Drawing.Point(42, 366);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(147, 15);
            this.ThresholdLabel.TabIndex = 5;
            this.ThresholdLabel.Text = "Black and White Threshold";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(212, 366);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radioButtonOriginal
            // 
            this.radioButtonOriginal.AutoSize = true;
            this.radioButtonOriginal.Checked = true;
            this.radioButtonOriginal.Location = new System.Drawing.Point(43, 319);
            this.radioButtonOriginal.Name = "radioButtonOriginal";
            this.radioButtonOriginal.Size = new System.Drawing.Size(67, 19);
            this.radioButtonOriginal.TabIndex = 8;
            this.radioButtonOriginal.TabStop = true;
            this.radioButtonOriginal.Text = "Original";
            this.radioButtonOriginal.UseVisualStyleBackColor = true;
            this.radioButtonOriginal.CheckedChanged += new System.EventHandler(this.radioButtonOriginal_CheckedChanged);
            // 
            // radioButtonGrayscale
            // 
            this.radioButtonGrayscale.AutoSize = true;
            this.radioButtonGrayscale.Location = new System.Drawing.Point(183, 318);
            this.radioButtonGrayscale.Name = "radioButtonGrayscale";
            this.radioButtonGrayscale.Size = new System.Drawing.Size(75, 19);
            this.radioButtonGrayscale.TabIndex = 9;
            this.radioButtonGrayscale.Text = "Grayscale";
            this.radioButtonGrayscale.UseVisualStyleBackColor = true;
            this.radioButtonGrayscale.CheckedChanged += new System.EventHandler(this.radioButtonGrayscale_CheckedChanged);
            // 
            // radioButtonBlackAndWhite
            // 
            this.radioButtonBlackAndWhite.AutoSize = true;
            this.radioButtonBlackAndWhite.Location = new System.Drawing.Point(314, 318);
            this.radioButtonBlackAndWhite.Name = "radioButtonBlackAndWhite";
            this.radioButtonBlackAndWhite.Size = new System.Drawing.Size(112, 19);
            this.radioButtonBlackAndWhite.TabIndex = 10;
            this.radioButtonBlackAndWhite.Text = "Black And White";
            this.radioButtonBlackAndWhite.UseVisualStyleBackColor = true;
            this.radioButtonBlackAndWhite.CheckedChanged += new System.EventHandler(this.radioButtonBlackAndWhite_CheckedChanged);
            // 
            // labelnput
            // 
            this.labelnput.AutoSize = true;
            this.labelnput.Location = new System.Drawing.Point(43, 31);
            this.labelnput.Name = "labelnput";
            this.labelnput.Size = new System.Drawing.Size(71, 15);
            this.labelnput.TabIndex = 11;
            this.labelnput.Text = "lnput Image";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(423, 30);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(81, 15);
            this.labelOutput.TabIndex = 12;
            this.labelOutput.Text = "Output Image";
            // 
            // ImageProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelnput);
            this.Controls.Add(this.radioButtonBlackAndWhite);
            this.Controls.Add(this.radioButtonGrayscale);
            this.Controls.Add(this.radioButtonOriginal);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ThresholdLabel);
            this.Controls.Add(this.OutputImageBox);
            this.Controls.Add(this.InputImageBox);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.LoadFileButton);
            this.Name = "ImageProcessingForm";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.InputImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox InputImageBox;
        private System.Windows.Forms.PictureBox OutputImageBox;
        private System.Windows.Forms.Label ThresholdLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButtonOriginal;
        private System.Windows.Forms.RadioButton radioButtonGrayscale;
        private System.Windows.Forms.RadioButton radioButtonBlackAndWhite;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelnput;
        private System.Windows.Forms.Label labelOutput;
    }
}

