using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дополнительное_задание
{
    struct Notebook
    {
        public string model;
        public string brand;
        public double price;

        public Notebook(string a, string b, double c)
        {
            model = a; brand = b; price = c; 
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"model = {model}, brand = {brand}, price = {price}");
        }
    }
    class Program
    {
        static void Main()
        {
            Notebook note = new Notebook("ProBook", "HP", 5600);

            note.DisplayInfo();

            Console.ReadKey();
        }
    }
}
