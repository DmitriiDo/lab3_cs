using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class CarsCatalog
    {
        public List<Car> cars = new();

        public string? this[int index]
        {
            get
            {
                return $"Car: {cars[index]?.Name} {cars[index]?.Engine}";
            }
        }
    }
}
