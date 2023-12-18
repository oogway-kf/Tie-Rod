
namespace PluginForCAD.Model
{
    //TODO: XML
    public class TieRodParameters
    {
        /// <summary>
        /// Словарь, хранящий тип параметра и соответствующий ему экземпляр параметра.
        /// </summary>
        private Dictionary<ParametersType, Parameter> _parameters;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public TieRodParameters()
        {

            _parameters = new Dictionary<ParametersType, Parameter>()
            {
                { 
                    ParametersType.BigPartLength, 
                    new Parameter(340, 300, 380) 
                },
                { 
                    ParametersType.SmallPartLength, 
                    new Parameter(132.5,75, 190) 
                },
                { 
                    ParametersType.BigPartDiameter,
                    new Parameter(25, 20, 30) 
                },
                {
                    ParametersType.SmallPartDiameter,
                    new Parameter(15.5, 10, 21)
                },
                {
                    ParametersType.ChamferLength,
                    new Parameter(8.5, 7, 10)
                }             
            };
        }

        /// <summary>
        /// Передача значения параметра.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <param name="value">Значение параметра.</param>
        public void SetParameterValue(ParametersType type, double value)
        {
            var parameter = _parameters[type];
            CheckPermissibleValues(type, value);
            parameter.Value = value;
        }

        /// <summary>
        /// Получить значение параметра.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <returns>Значение параметра.</returns>
        /// <exception cref="Exception">Если параметр не существует.</exception>
        public double GetParameterValue(ParametersType type)
        {
            return _parameters[type].Value;
        }

        
        /// <summary>
        /// Проверка допустимости значений.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <param name="value">Значение параметра.</param>
        /// <exception cref="Exception">Если введенный параметр некорректен.</exception>
        private void CheckPermissibleValues(ParametersType type, double value)
        {
            if (type == ParametersType.SmallPartLength)
            {
                _parameters.TryGetValue(ParametersType.BigPartLength, out var parameter);
                if (value > 0.5 * parameter.Value || value < 0.25 * parameter.Value)
                {
                    throw new ArgumentOutOfRangeException(
                        "Длина малой части не может быть " +
                        "больше 1/2 или меньше 1/4 длины большей части");
                }
            }
            if (type == ParametersType.SmallPartDiameter)
            {
                _parameters.TryGetValue(ParametersType.BigPartDiameter, out var parameter);
                if (value > 0.7 * parameter.Value || value < 0.5 * parameter.Value)
                {
                    throw new ArgumentOutOfRangeException(
                        "Диаметр малой части не может быть " +
                        "больше 70% или меньше 50% диаметра большей части");
                }    
            }

        }
    }
}
