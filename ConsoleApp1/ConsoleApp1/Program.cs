using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Jacob\Workspace\dad's exercises\TextFile1.txt");
            var splitText = text.Split(" ");
            string newText = "";
            for (int i = splitText.Length - 1; i > -1; i--)
            {
                newText += splitText[i] + " ";
            }
            System.IO.File.WriteAllText(@"C:\Users\Jacob\Workspace\dad's exercises\TextFile2.txt", newText);
        }
    }
}
