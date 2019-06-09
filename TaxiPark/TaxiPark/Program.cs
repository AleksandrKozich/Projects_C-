using System;
using System.Linq;



namespace TaxiPark
{
   
        //Таксопарк. Определить иерархию легковых автомобилей.

        //Создать таксопарк. Посчитать стоимость автопарка.

        //Провести сортировку автомобилей парка по расходу топлива.

        //Найти автомобиль в компании, соответствующий заданному диапазону параметров скорости.

        class Program

        {

            static void Main(string[] args)

            {

                CarPark park = new CarPark {

                new Minivan {

                    Name = "name1",

                    Price = 12,

                    MaxSpeed = 100,

                    ReleaseYear = new DateTime(2000, 1, 1),

                    Consumption = 6,

                    EngineType = EngineType.Dissel

                },

                new Sedan {

                    Name = "name2",

                    Price = 13,

                    MaxSpeed = 120,

                    ReleaseYear = new DateTime(2000, 1, 1),

                    Consumption = 8,

                    EngineType = EngineType.Dissel

                },

                new Bus {

                    Name = "name3",

                    Price = 19,

                    MaxSpeed = 200,

                    ReleaseYear = new DateTime(2000, 1, 1),

                    Consumption = 4,

                    EngineType = EngineType.Gas

                },

                new Bus {

                    Name = "name4",

                    Price = 4,

                    MaxSpeed = 130,

                    ReleaseYear = new DateTime(2000, 1, 1),

                    Consumption = 0,

                    EngineType = EngineType.Electric

                },

                new Sedan {

                    Name = "name5",

                    Price = 10,

                    MaxSpeed = 400,

                    ReleaseYear = new DateTime(2000, 1, 1),

                    Consumption = 70,

                    EngineType = EngineType.Gas

                },

            };



                var sum = park.Sum;

                var sorted = park.Sort().ToList();

                var serch = park.Search(new SearchCarModel { FromSpeed = 20, ToSpeed = 200 }).ToList();


          
          //  Console.ReadKey();


            }

        }

    }