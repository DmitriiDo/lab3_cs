using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class Car : IEquatable<Car>
    {
        public string Name { get; set; }
        public string Engine { get; set; }
        public float MaxSpeed { get; set; }

        private const float eps = 1e-6f;

        public bool Equals(Car? other)
        {
            return Name.Equals(other?.Name) &&
                   Engine.Equals(other?.Engine) &&
                   Approximately(MaxSpeed, other?.MaxSpeed);
        }

        public override string ToString()
        {
            return Name;
        }

        private static bool Approximately(float lhs, float? rhs)
        {
            if (rhs is null) return false;
            return lhs + eps > rhs && lhs - eps < rhs;
        }


    }
}
