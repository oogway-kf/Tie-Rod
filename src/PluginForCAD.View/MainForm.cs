using PluginForCAD.Model;
using PluginForCAD.Wrapper;

namespace PluginForCAD.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Параметры рейки.
        /// </summary>
        private TieRodParameters _parameters;

        /// <summary>
        /// Словарь, хранящий поле ввода и соответствующий ему параметр.
        /// </summary>
        private Dictionary<TextBox, ParametersType> _textBoxParametersType;

        /// <summary>
        /// Хранит текстбокс и ошибку в нем.
        /// </summary>
        private readonly Dictionary<TextBox, string> _textBoxAndError;

        public MainForm()
        {
            InitializeComponent();
            _parameters = new TieRodParameters();
            _textBoxParametersType = new Dictionary<TextBox, ParametersType>
            {
                { BigPartLengthTextBox, ParametersType.BigPartLength},
                { SmallPartLengthTextBox, ParametersType.SmallPartLength },
                { BigPartDiameterTextBox, ParametersType. BigPartDiameter },
                { SmallPartDiameterTextBox, ParametersType.SmallPartDiameter },
                { ChamferLengthTextBox, ParametersType.ChamferLength },
            };
            _textBoxAndError = new Dictionary<TextBox, string>
            {
                { BigPartLengthTextBox, "" },
                { SmallPartLengthTextBox, "" },
                { BigPartDiameterTextBox, "" },
                { SmallPartDiameterTextBox, "" },
                { ChamferLengthTextBox, "" },

            };
            BigPartLengthTextBox.Text =
                _parameters.GetParameterValue(ParametersType.BigPartLength).ToString();
            SmallPartLengthTextBox.Text =
                _parameters.GetParameterValue(ParametersType.SmallPartLength).ToString();
            BigPartDiameterTextBox.Text =
                _parameters.GetParameterValue(ParametersType.BigPartDiameter).ToString();
            SmallPartDiameterTextBox.Text =
                _parameters.GetParameterValue(ParametersType.SmallPartDiameter).ToString();
            ChamferLengthTextBox.Text =
                _parameters.GetParameterValue(ParametersType.ChamferLength).ToString();
        }

        /// <summary>
        /// Передает значение параметра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetParameter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var isType = _textBoxParametersType.TryGetValue(textBox, out var type);
            var textValue = textBox.Text.Replace('.', ',');
            double.TryParse(textValue, out var value);
            value = Math.Round(value, 1);            

            if (!isType) return;

            try
            {
                _parameters.SetParameterValue(type, value);
                _textBoxAndError[textBox] = "";
                errorProvider.Clear();
            }
            catch (ArgumentOutOfRangeException error)
            {
                _textBoxAndError[textBox] = error.ParamName;
                errorProvider.SetError(textBox, error.ParamName);
            }
        }

        /// <summary>
        /// Очистка поля ввода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearTextBox(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        /// <summary>
        /// Установить дефолтные значения в текстбоксы.
        /// </summary>
        /// <param name="bigPartLength"></param>
        /// <param name="smallPartLength"></param>
        /// <param name="bigPartDiameter"></param>
        /// <param name="smallPartDiameter"></param>
        /// <param name="ChamferLength"></param>
        private void SetParameters(double bigPartLength, double smallPartLength,
            double bigPartDiameter, double smallPartDiameter,
            double ChamferLength)
        {
            _parameters.SetParameterValue(ParametersType.BigPartLength, bigPartLength);
            _parameters.SetParameterValue(ParametersType.SmallPartLength, smallPartLength);
            _parameters.SetParameterValue(ParametersType.BigPartDiameter, bigPartDiameter);
            _parameters.SetParameterValue(ParametersType.SmallPartDiameter, smallPartDiameter);
            _parameters.SetParameterValue(ParametersType.ChamferLength, ChamferLength);

            BigPartLengthTextBox.Text = bigPartLength.ToString();
            SmallPartLengthTextBox.Text = smallPartLength.ToString();
            BigPartDiameterTextBox.Text = bigPartDiameter.ToString();
            SmallPartDiameterTextBox.Text = smallPartDiameter.ToString();
            ChamferLengthTextBox.Text = ChamferLength.ToString();
        }

        /// <summary>
        /// Проверка значений.
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            var isError = true;
            foreach (var item in
                     _textBoxAndError.Where(item => item.Value != ""))
            {
                isError = false;
                errorProvider.SetError(item.Key, item.Value);
            }

            return isError;
        }


        /// <summary>
        /// Нажатие на кнопку Build.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildTieRodButton_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                var builder = new TieRodBuilder();
                builder.BuildTieRod(_parameters);
            }
            else
            {
                MessageBox.Show(@"Заполните параметры корректно.");
            }
        }

        /// <summary>
        /// Установить дефолтные параметры рейки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetDefaultParameters(object sender, EventArgs e)
        {
            var buttonName = (sender as Button)?.Name;

            switch (buttonName)
            {
                case "MinimumParametersButton":
                    {
                        SetParameters(300, 75, 20, 10, 7);
                        break;
                    }
                case "AverageParametersButton":
                    {
                        SetParameters(340, 132.5, 25, 15.5, 8.5);
                        break;
                    }
                case "MaximumParametersButton":
                    {
                        SetParameters(380, 190, 30, 21, 10);
                        break;
                    }
            }
        }

 
    }
}