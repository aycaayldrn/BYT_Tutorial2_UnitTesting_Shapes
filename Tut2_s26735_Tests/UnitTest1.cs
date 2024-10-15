using Tut2_s26735;

namespace Tut2_s26735_Tests
{
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5);
        private readonly IShape cylinder = new Cylinder(3, 7);
        private readonly IShape rectangle = new Rectangle(4, 8);
        private readonly IShape cube = new Cube(4);
        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculatedArea()
        {
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculatedVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32.001).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCubeCalculatedArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(96.0).Within(0.001));
        }

        [Test]
        public void TestCubeCalculatedVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));
        }


    }
}