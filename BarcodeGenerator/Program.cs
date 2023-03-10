using System;
using System.Drawing;
using ZXing;
using System.IO;


namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "5901234123457";
            string fileName = @"F:\\barcodes\\" + data + ".svg";
            var barcodeWriter = new BarcodeWriterSvg()
            {
                Format = BarcodeFormat.EAN_13, 
                
            };

            var svgBarcode = barcodeWriter.Write(data);
            File.WriteAllText(fileName, svgBarcode.ToString());



            string fileNameSaved = @"F:\\barcodes\\5901234123457.png";
            BarcodeReader barcodeReader = new BarcodeReader();
            var barcodeBitmapp = (Bitmap)Bitmap.FromFile(fileNameSaved);
            var barcodeResult = barcodeReader.Decode(barcodeBitmapp);

            if (barcodeResult != null)
            {
                Console.WriteLine("Barkod metni: " + barcodeResult);
            }
            else
            {
                Console.WriteLine("Barkod okunamadı.");
            }




        }
    }
}
