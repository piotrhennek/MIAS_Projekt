using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic
{
    public static class DataLogger
    {
        public static void Log(StringBuilder msg)
        {
            StringBuilder csvContent = new StringBuilder();
            string naglowek = string.Empty;
            string fileName = @"C:\Temp\logs.csv";
            FileInfo file = new FileInfo(fileName);
            if (!file.Exists)
            {
                file.Directory.Create();
                naglowek = "Query,Database,Time";
                csvContent.AppendLine(naglowek);
            }
            
            csvContent.AppendLine(msg.ToString());
            //  using (StreamWriter writer = file.AppendText())
            // //  {
            //     if (!string.IsNullOrEmpty(naglowek))
            ///        writer.WriteLine(naglowek);
            //  writer.WriteLine(msg);
            //}
            File.AppendAllText(fileName, csvContent.ToString());
        }
    }
}
