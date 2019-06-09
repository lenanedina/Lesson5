using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task7();
            Task13();
            Task4();
            Task20();

        }
        static void Task1()
        {
            int[] mas = new int[8] { 37, 0, 50, 46, 34, 46, 0, 13 };
             foreach (int i in mas)
             {
                Console.WriteLine(i);
             }
             
        }
        static void Task7()
        {
            int[] numbers = new int[8] {8,7,6,5,4,3,2,1};
            {
                Console.WriteLine("Масив :");
                foreach (int elem in numbers)
                Console.WriteLine("{0} ", elem);
                Array.Sort(numbers);
                Console.WriteLine("по возрастанию");
                foreach (int elem in numbers)
                Console.WriteLine("{0} ", elem) ;
                
            }
        }

        static void Task13()
        {
            int[] a = new int[6] { 5, 8, 6, 3, 7, 2 };
            {
                Array.Reverse(a);
                Console.WriteLine("Обратный порядок: ");
                foreach (int elem in a)
                Console.WriteLine("{0} ", elem);
            }
        }
        static void Task4()
        {
            int[] mas = new int[12];
            Random r = new Random();
            for (int i=0; i <mas.Length;i++)
            {
                mas[i] = r.Next(162, 191);
                Console.WriteLine("Рост: " + mas[i]);
            }
        }
        static void Task20()
        {
            int[] mas = new int[12];
            int sum = 0;
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(150, 555);
                Console.WriteLine("Цена: " + mas[i] + " грн.");
                sum += mas[i];
            }
            Console.WriteLine($"Общая стоимость товаров = {sum}" + " грн.");
        }
           
    }





}
