using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number..");
            int dec = Convert.ToInt16( Console.ReadLine());
            string index1, index2, index3, index4, index5, index6, index7, index8, index9;
            


            if (dec == 1)
            {
                index1 = Convert.ToString(dec % 2);

                string bin = "0000000" + index1;
                Console.WriteLine(bin);
            }
            else if (dec == 2)
            {
                index2 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index1 = Convert.ToString(dec % 2);

                string bin = "000000" + index1 + index2 ;
                Console.WriteLine(bin);
            }
            else if (dec > 2 && dec <= 4)
            {
                index3 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index2 = Convert.ToString( dec % 2 );
                dec = dec / 2;

                index1 = Convert.ToString(dec % 2);

                string bin = "00000" + index1 + index2 + index3;
                Console.WriteLine(bin);

            }
            else if (dec > 4 && dec <= 8)
            {
                index4 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index3 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index2 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index1 = Convert.ToString(dec % 2);

                string bin = "0000" + index1 + index2 + index3 + index4;
                Console.WriteLine(bin);
            }
            else if (dec > 8 && dec <= 16)
            {
                index5 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index4 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index3 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index2 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index1 = Convert.ToString(dec % 2);

                string bin = "000" + index1 + index2 + index3 + index4 + index5;
                Console.WriteLine(bin);
            }
            else if (dec > 16 && dec <= 32)
            {
                index6 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index5 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index4 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index3 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index2 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index1 = Convert.ToString(dec % 2);

                string bin = "00" + index1 + index2 + index3 + index4 + index5 + index6;
                Console.WriteLine(bin);
            }
            else if (dec > 32 && dec <= 64)
            {
                index7 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index6 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index5 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index4 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index3 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index2 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index1 = Convert.ToString(dec % 2);

                string bin = "0" + index1 + index2 + index3 + index4 + index5 + index6 + index7;
                Console.WriteLine(bin);
            }
            else if (dec > 64 && dec <= 128)
            {
                index8 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index7 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index6 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index5 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index4 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index3 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index2 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index1 = Convert.ToString(dec % 2);

                string bin = index1 + index2 + index3 + index4 + index5 + index6 + index7 + index8;
                Console.WriteLine(bin);
            }
            else if (dec > 128 && dec <= 256)
            {
                index9 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index8 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index7 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index6 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index5 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index4 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index3 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index2 = Convert.ToString(dec % 2);
                dec = dec / 2;

                index1 = Convert.ToString(dec % 2);

                string bin = index1 + index2 + index3 + index4 + index5 + index6 + index7 + index8 + index9;
                Console.WriteLine(bin);
            }
            else
            {
                Console.WriteLine("Out Of Range");
            }
            Console.ReadKey();




        }
    }
}
