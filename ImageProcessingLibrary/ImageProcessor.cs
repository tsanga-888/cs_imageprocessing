using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;


namespace ImageProcessingLibrary
{
    /// <summary>
    /// ImageProcessing using ImageSharp to manipulate and process the image.
    /// </summary>
    public class ImageProcessor : IImageProcessor
    {

        /// <summary>
        /// Resize Image width and height.
        /// </summary>
        /// <param name="data">The image as array of bytes.</param>
        /// <param name="width">The new width to be resized. </param>
        /// <param name="height">the new height to be resized.</param>
        /// <returns></returns>
        public byte[] resize(byte[] data, int width, int height)
        {

            byte[] output = null;
            using (Image<Rgba32> image = Image<Rgba32>.Load(data))
            {
                // Resize
                image.Mutate(x => x.Resize(width, height));
                output = getBytes(image);
            }

            return output;
        }

        /// <summary>
        /// Converts a Image to grayscale.
        /// </summary>
        /// <param name="data">The image as array of bytes</param>
        /// <returns>Grayscaled image as array of byte</returns>
        public byte[] grayScale(byte[] data) {

            byte[] output = null;
                using (Image<Rgba32> image = Image<Rgba32>.Load(data))
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        for (int y = 0; y < image.Height; y++)
                        {
                            // replace the RGA with the gray
                            image[x, y] = Rgba32ToGray(image[x, y]);
                        }
                    }
                    output = getBytes(image);
                }
         
            return output;
        }

        /// <summary>
        /// Convert Rgba32 pixel to gray. Using a weighted formula.
        /// Red 33%
        /// Green 59%
        /// Blue 11%
        /// </summary>
        /// <param name="pixel"></param>
        /// <returns></returns>
        private Rgba32 Rgba32ToGray(Rgba32 pixel)
        {
            // Pixel RGBA component
            byte red = pixel.R;
            byte green = pixel.G;
            byte blue = pixel.B;
            byte alpha = pixel.A;

            double weighted = (byte)(red * 0.3) + (green * 0.59) + (blue * 0.11);
            byte gray = (byte)weighted;

            return new Rgba32(gray, gray, gray, alpha);
        }

        /// <summary>
        /// Convert and image to black and white with a gray threshold above 127 for white.
        /// </summary>
        /// <param name="data">Image data as array of bytes.</param>
        /// <returns>Processed Image as array of bytes.</returns>
        public byte[] blackAndWhite(byte[] data)
        {
            byte[] output = null;
            //ImageProcessor.Processors.
            output = blackAndWhite( data, 127);
            return output;
        }

        /// <summary>
        /// Convert and image to black and white with a gray threshold for white defined by user.
        /// </summary>
        /// <param name="data">Image data as array of bytes.</param>
        /// <param name="threshold">User define value for the white threshold by the user equal and above.</param>
        /// <returns>Processed Image as array of bytes.</returns>        
        public byte[] blackAndWhite(byte[] data,byte threshold = 127)
        {
            byte[] output = null;
            //ImageProcessor.Processors.
            using (Image<Rgba32> image = Image<Rgba32>.Load(data))
            {
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        // replace the RGA with the gray
                        Rgba32 gray = Rgba32ToGray(image[x, y]);

                        // red = green = blue
                        if (gray.R >= threshold)
                        {
                            // White
                            image[x, y] = new Rgba32(255, 255, 255, gray.A);
                        } else {
                            // Black
                            image[x, y] = new Rgba32(0, 0, 0, gray.A);
                        }
                                                
                    }
                }
                output = getBytes(image);
            }            
            return output;
        }

        /// <summary>
        /// Open a image file on filename.
        /// </summary>
        /// <param name="fileName">Image file name.</param>
        /// <returns>Image as array of bytes.</returns>        
        public byte[] openFile(string fileName)
        {
            byte[] output = null;
            using (Image<Rgba32> image = Image.Load<Rgba32>(fileName))
            {
                output = getBytes(image);
            }
            return output;
        }

        /// <summary>
        /// Save an image that is array of bytes to jpeg/jpg.
        /// </summary>
        /// <param name="data">Image as array of bytes</param>
        /// <param name="filePath">The Folder the image file to be saved</param>
        /// <param name="fileName">The file name for the image to be saved.</param>
        public void saveFile(byte[] data, string filePath, string fileName)
        {
            using (Image<Rgba32> image = Image.Load<Rgba32>(data))
            {
                image.SaveAsJpeg(Path.Combine(filePath,fileName));
            }            
        }


        /// <summary>
        /// Convert a image to array of bytes.
        /// </summary>
        /// <param name="image">The image to be convert to array of bytes.</param>
        /// <returns>Image as array of bytes.</returns>      
        public byte[] getBytes(Image image)
        {
            byte[] output = null;
            // Save to memory and get the bytes
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.SaveAsBmp(memoryStream);
                output = memoryStream.ToArray();
            }
            return output;
        }

        /// <summary>
        /// Convert a image Rgba32 to array of bytes.
        /// </summary>
        /// <param name="image">The image Rgba32 to be convert to array of bytes.</param>
        /// <returns>Image Rgba32 as array of bytes.</returns>      
        public byte[] getBytes(Image<Rgba32> image)
        {
            byte[] output = null;
            // Save to memory and get the bytes
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.SaveAsBmp(memoryStream);
                output = memoryStream.ToArray();
            }
            return output;
        }

    }
}

