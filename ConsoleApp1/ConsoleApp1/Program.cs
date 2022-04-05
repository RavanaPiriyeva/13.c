using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Name = "ASUS";
            notebook1.No = 1;
            notebook1.Price = 3000;

            Notebook notebook2 = new Notebook();
            notebook2.Name = "HP";
            notebook2.No = 2;
            notebook2.Price = 2000;

            Notebook notebook3 = new Notebook();
            notebook3.Name = "TOSHIBA";
            notebook3.No = 3;
            notebook3.Price = 2000;


            Phone phone1 = new Phone();
            phone1.Name = "IPHONE";
            phone1.No = 1;
            phone1.Price = 500;

            Phone phone2 = new Phone();
            phone2.Name = "SAMSUNG";
            phone2.No = 2;
            phone2.Price = 1000;

            Phone phone3 = new Phone();
            phone3.Name = "XIAOMI";
            phone3.No = 3;
            phone3.Price = 1500;


            Store store = new Store();
            store.NotebookLimit = 2;
            store.PhoneLimit = 3;
            store.AddProduct(notebook1);
            store.AddProduct(notebook2);
            store.AddProduct(notebook3);
            store.AddProduct(phone1);
            store.AddProduct(phone2);
            store.AddProduct(phone3);
            Console.WriteLine("\nNo deyerine gore axtar:");
            int no = Convert.ToInt32(Console.ReadLine());
           store.FindByNo(no);
            Console.WriteLine("\n\n\nNotebooklarin ededi ortasi");
            Console.WriteLine(store.CalcNotebookAvg());
            Console.WriteLine("\nTelefonlarin ededi ortasi");
            Console.WriteLine(store.CalcPhoneAvg());
            Console.WriteLine("\n\n=============================== PRODUCTS =============================\n");
            foreach (var item in store.Products)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
