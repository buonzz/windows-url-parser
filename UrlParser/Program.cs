using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlParser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static List<ParsedUrl> ParseUrls(IEnumerable<string> raw_urls)
        {
            List<ParsedUrl> output = new List<ParsedUrl>();
            return output;
        }


        public static IEnumerable<string> SplitToLines(this string input)
        {
            if (input == null)
            {
                yield break;
            }

            using (System.IO.StringReader reader = new System.IO.StringReader(input))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        } // splittolines



    }
}
