using PluginForCAD.Model;

namespace PluginForCAD.UnitTests
{
    public class TieRodParametersTests
    {
        /// <summary>
        /// ��������� ������� ����.
        /// </summary>
        private TieRodParameters _parameters = new TieRodParameters();

        public void Setup()
        {
            TestSetPermissibleParameter_CorrectValues();
            TestSetPermissibleParameter_IncorrectValues();
        }

        [Test(Description ="���������� ����")]
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

        [Test(Description = "���������� ����")]
        public void TestSetPermissibleParameter_IncorrectValues()
        {
            const string expectedSmallPartLengthException =
                "����� ����� ����� �� ����� ���� ������ 1/2 ��� ������ 1/4 ����� ������� �����";
            const string expectedSmallPartDiameterException =
                "������� ����� ����� �� ����� ���� ������ 70% ��� ������ 50% �������� ������� �����";


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