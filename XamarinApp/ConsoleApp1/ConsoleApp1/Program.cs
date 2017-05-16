using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = Directory.GetCurrentDirectory() + "\\PDF\\7A.pdf";
            String pdf = PDFParser(path);
            System.Console.Error.WriteLine(pdf);

            // obrada (nova metoda)
            StreamReader reader = new StreamReader(pdf);
            for (int i=0;i<6;i++)
            {
                reader.ReadLine();
            }

            String line;
            Dictionary<String, List<DateTime>> WD = new Dictionary<String, List<DateTime>>();
            Dictionary<String, List<DateTime>> SAT = new Dictionary<String, List<DateTime>>();
            Dictionary<String, List<DateTime>> SUN = new Dictionary<String, List<DateTime>>();

            while ((line = reader.ReadLine()) != null)
            {
                String hour = line.ToCharArray()[0].ToString() + line.ToCharArray()[1].ToString();
                if (line != hour + " " + hour)
                {
                    // smjer a
                    if ((line = reader.ReadLine()) != null)
                    {
                        List<char> charList = line.ToCharArray().ToList();
                        List<DateTime> startTime = new List<DateTime>();

                        // radni dani
                        // while petlja u novu metodu
                        while (true)
                        {
                            if (charList.GetRange(0,1).ToString().Equals(" "))
                            {
                                charList.RemoveRange(0,1);
                                break;
                            }
                            if (!charList.GetRange(0, 2).ToString().Equals(", "))
                            {
                                DateTime temp = DateTime.ParseExact((hour + charList.GetRange(0, 2).ToString()), "hh:mm", null);
                                startTime.Add(temp);
                                charList.RemoveRange(0, 2);
                            } else
                            {
                                charList.RemoveRange(0, 2);
                            }
                        }
                        WD.Add("a", startTime);
                        startTime.Clear();

                        // subota
                        while (true)
                        {
                            if (charList.GetRange(0, 1).ToString().Equals(" "))
                            {
                                charList.RemoveRange(0, 1);
                                break;
                            }
                            if (!charList.GetRange(0, 2).ToString().Equals(", "))
                            {
                                DateTime temp = DateTime.ParseExact((hour + charList.GetRange(0, 2).ToString()), "hh:mm", null);
                                startTime.Add(temp);
                                charList.RemoveRange(0, 2);
                            }
                            else
                            {
                                charList.RemoveRange(0, 2);
                            }
                        }
                        SAT.Add("a", startTime);
                        startTime.Clear();

                        // radni dani
                        while (true)
                        {
                            if (charList.GetRange(0, 1).ToString().Equals(" "))
                            {
                                charList.RemoveRange(0, 1);
                                break;
                            }
                            if (!charList.GetRange(0, 2).ToString().Equals(", "))
                            {
                                DateTime temp = DateTime.ParseExact((hour + charList.GetRange(0, 2).ToString()), "hh:mm", null);
                                startTime.Add(temp);
                                charList.RemoveRange(0, 2);
                            }
                            else
                            {
                                charList.RemoveRange(0, 2);
                            }
                        }
                        SUN.Add("a", startTime);
                        startTime.Clear();

                    }

                    if ((line = reader.ReadLine()) != null) { }

                    // smjer b
                    if ((line = reader.ReadLine()) != null)
                    {
                        List<char> charList = line.ToCharArray().ToList();
                        List<DateTime> startTime = new List<DateTime>();

                        // radni dani
                        // while petlja u novu metodu
                        while (true)
                        {
                            if (charList.GetRange(0, 1).ToString().Equals(" "))
                            {
                                charList.RemoveRange(0, 1);
                                break;
                            }
                            if (!charList.GetRange(0, 2).ToString().Equals(", "))
                            {
                                DateTime temp = DateTime.ParseExact((hour + charList.GetRange(0, 2).ToString()), "hh:mm", null);
                                startTime.Add(temp);
                                charList.RemoveRange(0, 2);
                            }
                            else
                            {
                                charList.RemoveRange(0, 2);
                            }
                        }
                        WD.Add("b", startTime);
                        startTime.Clear();

                        // subota
                        while (true)
                        {
                            if (charList.GetRange(0, 1).ToString().Equals(" "))
                            {
                                charList.RemoveRange(0, 1);
                                break;
                            }
                            if (!charList.GetRange(0, 2).ToString().Equals(", "))
                            {
                                DateTime temp = DateTime.ParseExact((hour + charList.GetRange(0, 2).ToString()), "hh:mm", null);
                                startTime.Add(temp);
                                charList.RemoveRange(0, 2);
                            }
                            else
                            {
                                charList.RemoveRange(0, 2);
                            }
                        }
                        SAT.Add("b", startTime);
                        startTime.Clear();

                        // radni dani
                        while (true)
                        {
                            if (charList.GetRange(0, 1).ToString().Equals(" "))
                            {
                                charList.RemoveRange(0, 1);
                                break;
                            }
                            if (!charList.GetRange(0, 2).ToString().Equals(", "))
                            {
                                DateTime temp = DateTime.ParseExact((hour + charList.GetRange(0, 2).ToString()), "hh:mm", null);
                                startTime.Add(temp);
                                charList.RemoveRange(0, 2);
                            }
                            else
                            {
                                charList.RemoveRange(0, 2);
                            }
                        }
                        SUN.Add("b", startTime);
                        startTime.Clear();

                    }
                }
            }
        }

        public static String PDFParser(String path)
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
