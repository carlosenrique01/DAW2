using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace TextFileReader_csharp
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objReader = new StreamReader("c:\\TEXT.txt");
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();

            foreach (string sOutput in arrText)
                Console.WriteLine(sOutput);
            Console.ReadLine();

        }
    }
}
