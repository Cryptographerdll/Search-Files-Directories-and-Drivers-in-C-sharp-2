using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Les_Fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string Fils = path + @"\Fichiers\Tert.txt";

            bool existe = false;

            existe = File.Exists(Fils);

            if (!existe)
            {
                Console.WriteLine("Fichier existe pas ");
                File.Create(Fils);
            }
            else
                Console.WriteLine("le fichier est existe en folder");
    
            Console.ReadLine();
        }
    }
}
