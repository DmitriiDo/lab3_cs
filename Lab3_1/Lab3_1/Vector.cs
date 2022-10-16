using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public struct Vector
    {
        public float X, Y, Z;
        private const float eps = 1e-6f;
        public static Vector operator+(Vector lhs, Vector rhs)
        {
            return new Vector
            {
                X = lhs.X + rhs.X,
                Y = lhs.Y + rhs.Y,
                Z = lhs.Z + rhs.Z
            };
        }

        public override string ToString()
        {
            return $"Vector:({X};{Y};{Z})";
        }

        public float LengthSquared()
        {
            return X * X + Y * Y + Z * Z; 
        }

        public static float operator*(Vector lhs, Vector rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z;
        }

        public static Vector operator*(Vector lhs, float num)
        {
            return new Vector
            {
                X = lhs.X * num,
                Y = lhs.Y * num,
                Z = lhs.Z * num
            };
        }

        public static Vector operator*(float num, Vector lhs)
        {
            return lhs * num;
        }

        public static bool operator==(Vector lhs, Vector rhs)
        {
            return Approximately(lhs.LengthSquared(), rhs.LengthSquared());
        }

        public static bool operator>(Vector lhs, Vector rhs)
        {
            return lhs.LengthSquared() > rhs.LengthSquared();
        }

        public static bool operator<(Vector lhs, Vector rhs)
        {
            return lhs.LengthSquared() < rhs.LengthSquared();
        }

        public static bool operator!=(Vector lhs, Vector rhs)
        {
            return !(lhs == rhs);
        }

        private static bool Approximately(float lhs, float rhs)
        {
            return (lhs + eps > rhs) && (lhs - eps < rhs);
        }

        
    }
}
