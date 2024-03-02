using PluginForCAD.Model;

namespace PluginForCAD.UnitTests
{
    public class TieRodParametersTests
    {
        /// <summary>
        /// ѕараметры рулевой т€ги.
        /// </summary>
        private TieRodParameters _parameters = new TieRodParameters();

        public void Setup()
        {
            TestSetPermissibleParameter_CorrectValues();
            TestSetPermissibleParameter_IncorrectValues();
        }

        [Test(Description ="ѕозитивный тест")]
        public void TestSetPermissibleParameter_CorrectValues()
        {
            var expectedSmallPartLength = _parameters.GetParameterValue(ParametersType.SmallPartLength);
            var expectedSmallPartDiameter = _parameters.GetParameterValue(ParametersType.SmallPartDiameter);

            _parameters.SetParameterValue(ParametersType.SmallPartLength, expectedSmallPartLength);
            _parameters.SetParameterValue(ParametersType.SmallPartDiameter, expectedSmallPartDiameter);

            Assert.Multiple(() =>
            {
                Assert.That(_parameters.GetParameterValue(ParametersType.SmallPartLength),
                    Is.EqualTo(expectedSmallPartLength));
                Assert.That(_parameters.GetParameterValue(ParametersType.SmallPartDiameter),
                    Is.EqualTo(expectedSmallPartDiameter));
            });
        }

        [Test(Description = "Ќегативный тест")]
        public void TestSetPermissibleParameter_IncorrectValues()
        {
            const string expectedSmallPartLengthException =
                "ƒлина малой части не может быть больше 1/2 или меньше 1/4 длины большей части";
            const string expectedSmallPartDiameterException =
                "ƒиаметр малой части не может быть больше 70% или меньше 50% диаметра большей части";


            var actualSmallPartLengthException = Assert.Throws<ArgumentOutOfRangeException>(() =>
                _parameters.SetParameterValue(ParametersType.SmallPartLength, 5));
            var actualdSmallPartDiameterException = Assert.Throws<ArgumentOutOfRangeException>(() =>
                _parameters.SetParameterValue(ParametersType.SmallPartDiameter, 5));

            Assert.Multiple(() =>
            {
                Assert.That(actualSmallPartLengthException?.ParamName, 
                    Is.EqualTo(expectedSmallPartLengthException));
                Assert.That(actualdSmallPartDiameterException?.ParamName,
                    Is.EqualTo(expectedSmallPartDiameterException));
            });
        }

    }
}