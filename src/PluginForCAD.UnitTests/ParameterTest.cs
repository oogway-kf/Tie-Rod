using PluginForCAD.Model;

namespace PluginForCAD.UnitTests
{
    public class ParameterTests
    {
        public void Setup()
        {
            TestValueGet_CorrectValue();
            TestValueMinValueGet_IncorrectValue();
            TestValueMaxValueGet_IncorrectValue();
        }

        [Test(Description = "Позитивный тест геттера.")]
        public void TestValueGet_CorrectValue()
        {
            const double expected = 5;

            var Parameter = new Parameter(5, 1, 10);
            var actual = Parameter.Value;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test(Description = "Негативный тест геттера. " +
            "Значение меньше допустимого.")]
        public void TestValueMinValueGet_IncorrectValue()
        {
            const double minValue = 10;
            const double maxValue = 15;
            const double value = 5;

            var actual = Assert.Throws<ArgumentOutOfRangeException>(() =>
                new Parameter(value, minValue, maxValue));
            var expected = $"Значение должно быть между {minValue} и {maxValue}";

            Assert.That(actual?.ParamName, Is.EqualTo(expected));
        }

        [Test(Description = "Негативный тест геттера. " +
            "Значение больше допустимого.")]
        public void TestValueMaxValueGet_IncorrectValue()
        {
            const double minValue = 10;
            const double maxValue = 15;
            const double value = 20;

            var actual = Assert.Throws<ArgumentOutOfRangeException>(() => 
                new Parameter(value, minValue, maxValue));
            var expected = $"Значение должно быть между {minValue} и {maxValue}";

            Assert.That(actual?.ParamName, Is.EqualTo(expected));
        }

    }
}