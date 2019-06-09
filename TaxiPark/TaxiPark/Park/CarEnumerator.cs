using System;
using System.Collections.Generic;
using System.Collections;



namespace TaxiPark
{
    public class CarEnumerator : IEnumerator<Car>

    {
               
        private CarPark _collection;

        private int curIndex;

        private Car curCar;
                          
        public CarEnumerator(CarPark collection)

        {

            _collection = collection;

            curIndex = -1;

            curCar = default(Car);
                       
        }
               
        public bool MoveNext()

        {

            //Avoids going beyond the end of the collection.

            if (++curIndex >= _collection.Count)

            {

                return false;

            }

            else

            {

                // Set current Car to next item in collection.

                curCar = _collection[curIndex];

            }

            return true;

        }



        public void Reset() { curIndex = -1; }



        void IDisposable.Dispose() { }



        public Car Current

        {

            get { return curCar; }

        }
                          
        object IEnumerator.Current

        {

            get { return Current; }

        }
               
    }
       
}