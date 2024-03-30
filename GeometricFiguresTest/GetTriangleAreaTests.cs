using GeometricFigures;

namespace GeometricFiguresTest
{
    [TestFixture]
    public class GetTriangleAreaTests
    {

        [TestCase(5, 5, 6, ExpectedResult = 12)]
        [TestCase(5, 2, 6, ExpectedResult = 4.683748498798798)]
        public double GetArea_Success(int side1, int side2, int side3) => Area.GetArea(side1, side2, side3);

        [TestCase(3, 2, -10)]
        [TestCase(0, 2, 2)]
        [TestCase(2, 0, 2)]
        [TestCase(2, 2, 0)]
        [TestCase(-2, 2, 2)]
        [TestCase(2, -2, 2)]
        [TestCase(2, 2, -2)]
        public void GetArea_SideLessOrEqualsZero_ThrowArgumentException(int side1, int side2, int side3)
    => Assert.Throws<ArgumentException>(
        () => Area.GetArea(side1, side2, side3));

        [TestCase(1, 1, 6)]
        [TestCase(6, 1, 1)]
        [TestCase(1, 6, 1)]
        public void GetArea_SumOfSidesLessThenSide_ThrowArgumentException(int side1, int side2, int side3)
=> Assert.Throws<ArgumentException>(
() => Area.GetArea(side1, side2, side3));
    }
}