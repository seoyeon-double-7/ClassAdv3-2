using ClassAdv3_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product("과자", 1000);
            Product product2 = new Product("아이스크림", 1000);
            Product product3 = new Product("케이크", 1000);


            Box box = new Box(10, 10);
            box.Width = 100; 
            box.Height = 100;
            Console.WriteLine("Area: " + box.GetArea());
            try
            {
                box.Width = -10; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}