

using GeometricFigures;

namespace GeometricFiguresTest
{
    [TestFixture]
    public class IsRightTriangleTests
    {
        [TestCase(15, 25, 20, ExpectedResult = true)]
        [TestCase(5, 2, 6, ExpectedResult = false)]
        public bool IsRightTriangle_Success(int side1, int side2, int side3) => Area.IsRightTriangle(side1, side2, side3);

        [TestCase(3, 2, -10)]
        [TestCase(0, 2, 2)]
        [TestCase(2, 0, 2)]
        [TestCase(2, 2, 0)]
        [TestCase(-2, 2, 2)]
        [TestCase(2, -2, 2)]
        [TestCase(2, 2, -2)]
        public void IsRightTriangle_SideLessOrEqualsZero_ThrowArgumentException(int side1, int side2, int side3)
    => Assert.Throws<ArgumentException>(
        () => Area.GetArea(side1, side2, side3));

        [TestCase(1, 1, 6)]
        [TestCase(6, 1, 1)]
        [TestCase(1, 6, 1)]
        public void IsRightTriangle_SumOfSidesLessThenSide_ThrowArgumentException(int side1, int side2, int side3)
=> Assert.Throws<ArgumentException>(
() => Area.GetArea(side1, side2, side3));
    }
}

