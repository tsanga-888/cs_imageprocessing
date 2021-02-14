using System;
using System.Drawing;
using System.IO;


namespace ImageProcessingLibrary
{

    /// <summary>
    /// ImageTool contain miscellaneous helper functions.
    /// </summary>
    public class ImageTool
    {
        /// <summary>
        /// Convert an Image byte array into a bitmap.
        /// </summary>
        /// <param name="data">Image byte array.</param>
        /// <returns>bitmap image</returns>
        public static Bitmap ByteToImage(byte[] data)
        {
            MemoryStream mStream = new MemoryStream();            
            mStream.Write(data, 0, Convert.ToInt32(data.Length));
            Bitmap bitmap = new Bitmap(mStream, false);
            mStream.Dispose();
            return bitmap;
        }
    }
}
