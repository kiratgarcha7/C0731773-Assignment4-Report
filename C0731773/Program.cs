using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace C0731773
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();

            Console.ReadLine();

        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:\\Users\\731773\\Downloads\\Beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    counter++;
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }








                Console.WriteLine("essay consist of lines: " + counter);


            }
        }
        public int FindNumberofBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }

            return countSpaces;
        }
    }
}