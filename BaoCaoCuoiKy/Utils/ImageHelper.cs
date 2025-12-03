using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace BaoCaoCuoiKy.Utils
{
    public static class ImageHelper
    {
        public static byte[] ImageToByteArray(Image image, ImageFormat format = null)
        {
            if (image == null) return null;
            format = format ?? ImageFormat.Png;
            using (var ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using (var ms = new MemoryStream(bytes))
            using (var temp = Image.FromStream(ms))
            {
                return (Image)temp.Clone();
            }
        }
    }
}