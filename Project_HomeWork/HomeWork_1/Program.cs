using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite chislo");
            
            string perem = Console.ReadLine() ;
                                          
            System.Console.WriteLine(CreateRes(perem));
                       
        }

        public static string CreateRes(string chislo)
        {
           string res1 = "Vvedeno nekorrectnoe chislo";
            
           switch (chislo)
            {
                case "1":
                    res1 = ("The entered number corresponds to Monday");
                    break;
                case "2":
                    res1 = ("The entered number corresponds to Tuesday");
                    break;
                case "3":
                    res1 = ("The entered number corresponds to Wednesday");
                    break;
                case "4":
                    res1 = ("The entered number corresponds to Thursday");
                    break;
                case "5":
                    res1 = ("The entered number corresponds to Friday");
                    break;
                case "6":
                    res1 = ("The entered number corresponds to Saturday");
                    break;
                case "7":
                    res1 = ("The entered number corresponds to Sunday");
                    break;

           }

            return res1;
        }

    }
}


