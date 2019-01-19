using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogics
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "1 2 3";

            string[] sep = new string[] { " " };
            var splitData = input.Split(sep, StringSplitOptions.None);
            string lastItem = splitData[splitData.Count() - 1];

            int lastItemInt = Convert.ToInt32(lastItem);
            //if (splitData.Count() >= 3 && (lastItemInt >= 3))
            //{
            //    int data =  Convert.ToInt32(splitData[lastItemInt - 1]) + Convert.ToInt32(splitData[lastItemInt - 2]);
            //}
            int[] f = new int[lastItemInt + 2];
            f[0] = 1;
            f[1] = 2;
            for (int i = 2; i <= lastItemInt; i++)
            {
                //f[i] = f[i - 1] + f[i - 2];
                f[i - 1] = f[i - 1] + f[i];
            }
            int final = f[lastItemInt];


            string inputt = "Raspberry,Tomato​,Strawberry​,Apple,Carrot";

            string[] arr = input.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            List<string> listData = arr.ToList<string>();

            listData.Sort();

            foreach (string fruit in listData)
            {
                Console.WriteLine(fruit);
            }

        }

        private static void FruitTaste(string fruit)
        {
            if (fruit.Equals("strawberry"))
            {
                if (fruit.Equals("apple"))
                {
                    Console.WriteLine("yuk");
                }
                else
                {
                    Console.WriteLine("delicious");
                }
            }
            if (fruit.Equals("apple"))
            {
                Console.WriteLine("good");
            }
            else
            {
                if (fruit.Equals("banana"))
                    Console.WriteLine("yellow");
                else
                    Console.WriteLine("okay");
            }

        }
    }
}
