using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using System.IO;

namespace XamarinApp.Resources
{
    class Functions
    {
        
        public Functions()
        {
        }
        public TimeSpan CalculateTravelTime(DateTime start, DateTime end)
        {
            return end.Subtract(start);
        }
        public List<Line> ReturnLinesThroughStation(String station)
        {
            List<Line> lines = new List<Line>();
            //...
            return lines;
        }
        public String PDFParser(String path)
        {
            PdfReader reader = new PdfReader(path);
            String page;
            StringBuilder builder = new StringBuilder();

            builder.Append(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, 1));

            page = builder.ToString();
            System.Diagnostics.Debug.WriteLine(page);

            return page;
        }
    }
}
