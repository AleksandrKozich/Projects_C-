using System.Collections.Generic;

namespace TaxiPark
{
    public interface ICarSearchable

    {

        IEnumerable<Car> Search(SearchCarModel model);

    }

}