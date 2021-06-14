using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ZXing;

namespace qRGenerate
{
    class QRgenerate 
    {       
        IBarcodeReader reader = new BarcodeReader();
       
        public QRgenerate()
        {
                
        }
        public void writeBarcode(string filename, string st)
        {
            var url = string.Format("SecretCode={0}", st);
            var barcodeWriter = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 10,
                    Width = 10,
                    Margin = 0                       
                }
            };
            using (var bitmap = barcodeWriter.Write(url))
            {                
                bitmap.Save(@"D:\Project C#\qRGenerate\qRGenerate\bin\Debug\QrCode\asdf.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }
        //CODE 128
        public void writeBarcode2(string filename, string st)
        {
            var url = string.Format("{0}", st);
            var barcodeWriter = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 6,
                    Width = 4,
                    Margin = 0
                }
            };
            using (var bitmap = barcodeWriter.Write("23123"))
            {
                bitmap.Save(@"D:\Project C#\qRGenerate\qRGenerate\bin\Debug\QrCode\asdf.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        public string Decoder()
        {
            var barcodeBitmap = (Bitmap)Bitmap.FromFile(@"D:\Project C#\qRGenerate\qRGenerate\bin\Debug\QrCode\qr-code.gif");
            var result = reader.Decode(barcodeBitmap);
            if (result != null)
            {
                return result.BarcodeFormat.ToString() + result.Text.ToString();
            }
            return "Ничего";
        }
    }
}
