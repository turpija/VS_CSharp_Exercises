using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace FileReadWrite
{
    internal class CreatePdf
    {
        public CreatePdf()
        {
            string filePath = @"C:\Users\turpija\Documents\Temp\Vjezba\custom.pdf";

            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(page);
            XFont naslovFont = new XFont("Verdana", 30);
            XFont contentFont = new XFont("Verdana", 10);


            double margin = 30;
            XPen pen = new XPen(XColors.Orange, 1);

            XRect naslovOkvir = new XRect(margin, margin, page.Width - margin * 2, page.Height*0.2 - margin * 2);
            XRect contentOkvir = new XRect(margin, margin + page.Height * .2, page.Width - margin * 2, page.Height * 0.8 - margin * 2);
            XRect contentInsideOkvir = new XRect(margin+20, margin+20 + page.Height * .2, page.Width - margin+20 * 2, page.Height * 0.8 - margin+20 * 2);


            graphics.DrawRectangle(pen, naslovOkvir);
            graphics.DrawString("Zdravo svjete !", naslovFont, XBrushes.Black, naslovOkvir, XStringFormats.Center);
            
            graphics.DrawRectangle(pen, contentOkvir);

            XTextFormatter tekst = new XTextFormatter(graphics);
            tekst.DrawString(ReadFromFile(), contentFont, XBrushes.Black, contentInsideOkvir, XStringFormat.TopLeft);

            document.Save(filePath);
        }

        private string ReadFromFile()
        {
            string filePath = @"C:\Users\turpija\Documents\Temp\Vjezba\NoviTekst.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
