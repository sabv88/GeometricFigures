using System.Reflection.Metadata;

namespace GeometricFigures
{
    public static class Area
    {
        /// <summary>
        /// Find the area of a triangle using Heron's formula
        /// </summary>
        /// <param name="firstSide">The first side of the triangle</param>
        /// <param name="secondSide">The second side of the triangle</param>
        /// <param name="thirdSide">The third side of the triangle</param>
        /// <returns>Returns the area of a triangle in a double-precision</returns
        /// <exception cref="ArgumentException">Thrown if side is zero or less than zero or if the sum of the lengths of the two sides less than the length of the third side.</exception>
        public static double GetArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
            {
                throw new ArgumentException("The side cannot be 0 and less.", nameof(firstSide));
            }

            if (secondSide <= 0)
            {
                throw new ArgumentException("The side cannot be 0 and less.", nameof(secondSide));
            }

            if (thirdSide <= 0)
            {
                throw new ArgumentException("The side cannot be 0 and less.", nameof(thirdSide));
            }

            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
            {
                throw new ArgumentException("The sum of the lengths of the two sides cannot be less or equal than the length of the third side");
            }

            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        }

        /// <summary>
        /// Check is triangle a right
        /// </summary>
        /// <param name="firstSide">The first side of the triangle</param>
        /// <param name="secondSide">The second side of the triangle</param>
        /// <param name="thirdSide">The third side of the triangle</param>
        /// <returns> </returns>
        public static bool IsRightTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
            {
                throw new ArgumentException("The side cannot be 0 and less.", nameof(firstSide));
            }

            if (secondSide <= 0)
            {
                throw new ArgumentException("The side cannot be 0 and less.", nameof(secondSide));
            }

            if (thirdSide <= 0)
            {
                throw new ArgumentException("The side cannot be 0 and less.", nameof(thirdSide));
            }

            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
            {
                throw new ArgumentException("The sum of the lengths of the two sides cannot be less or equal than the length of the third side");
            }

            double[] sides = new double[] { firstSide, secondSide, thirdSide };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) == 0;
        }

        /// <summary>
        /// Find the area of a circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>Returns the area of a circle in a double-precision</returns>
        /// <exception cref="ArgumentException">Thrown when the radius is 0 and less.</exception>
        public static double GetArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The radius cannot be 0 and less.", nameof(radius));
            }

            return Math.PI * radius * radius;
        }
    }
}