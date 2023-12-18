using PluginForCAD.Model;

namespace PluginForCAD.UnitTests;

public class Point2DTest
{
    //TODO: зачем?
    [SetUp]
    public void Setup()
    {
        TestXGet_CorrectValue();
        TestYGet_CorrectValue();
        TestEquals_CorrectValue();
    }

    [Test(Description = "Позитивный тест геттера X.")]
    public void TestXGet_CorrectValue()
    {
        const double expected = 10;

        var point2D = new Point2D(expected, 20);
        var actual = point2D.X;

        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test(Description = "Позитивный тест геттера Y.")]
    public void TestYGet_CorrectValue()
    {
        const double expected = 10;

        var point2D = new Point2D(20, expected);
        var actual = point2D.Y;

        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test(Description = "Позитивный тест метода Equals.")]
    public void TestEquals_CorrectValue()
    {
        var expected = new Point2D(0, 0);
        var actual = new Point2D(0, 0);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
