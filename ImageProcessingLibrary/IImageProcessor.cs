using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace ImageProcessingLibrary
{
    /// <summary>
    /// Interface IImageProcessor image manipulation functions.
    /// </summary>
    interface IImageProcessor
    {
        byte[] resize(byte[] data, int width, int height);
        byte[] grayScale(byte[] data);
        byte[] blackAndWhite(byte[] data, byte threshold = 127);
        byte[] openFile(String file);
        void saveFile(byte[] data, string filePath, string fileName);
        byte[] getBytes(Image image);
        byte[] getBytes(Image<Rgba32> image);
    }


}
