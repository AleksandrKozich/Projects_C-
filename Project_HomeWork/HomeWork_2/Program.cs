using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite chislo ");

            int perem = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine(CreateRes(perem));

        }

        public static int CreateRes(int chislo)
        {
            int res = chislo;
          
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{chislo} * {i} = {chislo * i}");
            }
           return res;
        }

           
    }

    }
