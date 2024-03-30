using GeometricFigures;

namespace GeometricFiguresTest
{
    [TestFixture]
    public class GetCircleAreaTests
    {

        [TestCase(1, ExpectedResult = 3.1415926535897931)]
        [TestCase(2, ExpectedResult = 12.566370614359172)]
        public double GetArea_Success(int radius) => Area.GetArea(radius);

        [TestCase(0)]
        [TestCase(-1)]
        public void GetArea_RadiusLessOrEqualsZero_ThrowArgumentException(int radius)
    => Assert.Throws<ArgumentException>(
        () => Area.GetArea(radius));
    }
}
