using ImageProcessingLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageProcessingApp
{
    public partial class ImageProcessingForm : Form
    {
        // implement of ImageProcessor to perform image maniplations
        private ImageProcessor _imageProcesor;
        // Flags for image munipulation
        private bool _flagOriginal;
        private bool _flagGrayscale;
        private bool _flagBlackAndWhite;
        // Input and Ouput image
        private byte[] _inputImage;
        private byte[] _outputImage;

        // Initialize variables
        public ImageProcessingForm()
        {
            InitializeComponent();
            
            _imageProcesor = new ImageProcessor();            
            _inputImage = null;
            _outputImage = null;
            _flagOriginal = true;
            _flagGrayscale = false;
            _flagBlackAndWhite = false;
            changeRadionButtons();
        }

        // Open and load an image file
        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;|" +
                                         "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png";
                openFileDialog1.DefaultExt = "*.bmp;*.jpg;*.jpeg;*.png";
                openFileDialog1.FileName = "";
                openFileDialog1.ShowDialog();
                string fileName = openFileDialog1.FileName;

                // Resize input and process
                if (File.Exists(fileName))
                { 
                    _inputImage = _imageProcesor.openFile(fileName);
                    _outputImage = _inputImage;
                    _outputImage = manipulateOutput(_inputImage);
                    // Resize and display
                    updateImages();
                }
            } catch (Exception ex) {
                MessageBox.Show("Unable to open file: \n" + ex.ToString());
            }
        }

        // Save the ouput image/
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_outputImage != null)
                {
                    saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
                    saveFileDialog1.FileName = "output";
                    saveFileDialog1.Filter = "Jpeg Files (*.jpg)|*.jpg";
                    saveFileDialog1.DefaultExt = "jpg";
                    saveFileDialog1.AddExtension = true;
                    saveFileDialog1.ShowDialog();                    
                    _imageProcesor.saveFile(_outputImage, "", saveFileDialog1.FileName);
                }
            } catch (Exception ex) {
                MessageBox.Show("Unable to save file: \n" + ex.ToString());
            }
        }

        // Change the value of the black and white threshold
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {            
            _outputImage = manipulateOutput(_inputImage);
            updateImages();
        }

        // Update (resize) the input and output picture box
        private void updateImages()
        {
            
            if (_inputImage != null) InputImageBox.Image = ImageTool.ByteToImage(_imageProcesor.resize(_inputImage, InputImageBox.Width, InputImageBox.Height));
            if (_outputImage != null)
            {             
                OutputImageBox.Image = ImageTool.ByteToImage(_imageProcesor.resize(_outputImage, OutputImageBox.Width, OutputImageBox.Height));
            }
        }

        // Perform image manipulation 
        private byte[] manipulateOutput(byte[] data)
        {
            if (_outputImage != null)
            {
                if (_flagOriginal)
                {
                    _outputImage = _inputImage;
                }
                else if (_flagGrayscale)
                {
                    _outputImage = _imageProcesor.grayScale(_inputImage);
                }
                else if (_flagBlackAndWhite)
                {
                    _outputImage = _imageProcesor.blackAndWhite(_inputImage, (byte)numericUpDown1.Value);
                } else {
                    _outputImage = _inputImage;
                }
                return _outputImage;
            }
            return data;
        }

        // change the radio buttons
        private void changeRadionButtons() {
            _flagOriginal = radioButtonOriginal.Checked;
            _flagGrayscale = radioButtonGrayscale.Checked;
            _flagBlackAndWhite = radioButtonBlackAndWhite.Checked;
            numericUpDown1.Enabled = _flagBlackAndWhite;          
        }

        // radiobutton event for Original
        private void radioButtonOriginal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOriginal.Checked)
            {
                    changeRadionButtons();
                    _outputImage = manipulateOutput(_inputImage);
                    updateImages();
            }
        }

        // radiobutton event for grayscale
        private void radioButtonGrayscale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGrayscale.Checked)
            {
                changeRadionButtons();
                _outputImage = manipulateOutput(_inputImage);
                updateImages();
            }
        }

        //// radiobutton event for black and white
        private void radioButtonBlackAndWhite_CheckedChanged(object sender, EventArgs e)
        {
                if (radioButtonBlackAndWhite.Checked)
                {
                    changeRadionButtons();
                    _outputImage = manipulateOutput(_inputImage);
                    updateImages();
                }
        }

    }
    
}
