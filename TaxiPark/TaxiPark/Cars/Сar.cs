using System;

namespace TaxiPark
{
    abstract public class Car

    {

        public string Name { get; set; }

        public double Price { get;  set; }

        public DateTime ReleaseYear { get; set; }

        public EngineType EngineType { get; set; }

        public int MaxSpeed { get; set; }

        public int Consumption { get; set; }



    }

}