using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Store
    {

        private Product[] _products= new Product[0];
        //private int _notebooklimit;
        //private int _phonelimit;
       public  Product [] Products { get { return _products; } }
        public int NotebookLimit ;
        public int PhoneLimit ;
        public static int NotebookCount=0;
        public static int PhoneCount=0;
       
     


        public void AddProduct(Product product)
        {
            if(product is Notebook) { 
            if(  NotebookCount < NotebookLimit) { 
            Array.Resize(ref _products, _products.Length+1);
            _products[_products.Length-1] = product;
                NotebookCount++;
            }
                else
                {
                    Console.WriteLine("Siz notebooklar ucun limiti kecmisiz");
                }
            }

            if(product is Phone) { 
           if   (  PhoneCount < PhoneLimit)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
                PhoneCount++;
            }
            else
            {
                Console.WriteLine("Siz telefonlar ucun limiti kecmisiz");
            }
            }
        }

        
        public void FindByNo(int no)
        {
            Console.WriteLine("===================== PRODUCTS ====================\n");
            foreach (var item in _products)
            {
                if (item.No == no)
                {

                    Console.WriteLine($" {item.Name}");
                }
            }
            Console.WriteLine("\n--------------------------------------------------");
            
        }
        public double CalcNotebookAvg()
        {
            int count = 0;
            double  sum = 0;
            foreach(var pr in _products)
            {
                if (pr is Notebook)
                {
                    Notebook notebook = (Notebook)pr;
                    sum += notebook.Price;
                    count++;
                }
            }
            return sum/count;
        }


        public double CalcPhoneAvg()
        {
            int count = 0;
            double sum = 0;
            foreach (var pr in _products)
            {
                if (pr is Phone)
                {
                    Phone phone = (Phone)pr;
                    sum += phone.Price;
                    count++;
                }
            }
            return sum / count;
        }



        //        - Products - Product array
        //- AddProduct() - product typeda dəyər qəbul edib array-ə əlavə edir
        //- NotebookLimit - marketə əlavə edilə bilinəcək notebook limiti
        //- PhoneLimit - marketə əlavə edilə bilinəcək phone limiti
        //- FindByNo() - göndərilmiş no dəyərinə əsasən producti qaytarır
        //- CalcNotebookAvg() - marketdəki bütün notbookların ortalama qiymətini hesablayır
        //- CalcPhoneAvg() - marketdəki bütün telefonların ortalama qiymətini hesablayır
    }
}
