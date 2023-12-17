namespace PluginForCAD.Model;
public class Parameter
{
    /// <summary>
    /// Значение параметра.
    /// </summary>
    private double _value;

    /// <summary>
    /// Минимальное значение параметра.
    /// </summary>
    private readonly double _minValue;

    /// <summary>
    /// Максимальное значение параметра.
    /// </summary>
    private readonly double _maxValue;

    /// <summary>
    /// Сеттер и геттер value.
    /// </summary>
    public double Value
    {
        get => _value;
        set
        {
            if (IsRangeOut(value))
            {
                throw new ArgumentOutOfRangeException($"Значение должно быть между " +
                    $"{_minValue} и {_maxValue}");
            }
            _value = value;
        }
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="value"> Текущее значение</param>
    /// <param name="minValue"> Минимальное значение</param>
    /// <param name="maxValue"> Максимальное значение</param>
    public Parameter(double value, double minValue, double maxValue)
    {
        _minValue = minValue;
        _maxValue = maxValue;
        Value = value;
    }

    /// <summary>
    /// Контроль значения в допустимых пределах.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private bool IsRangeOut(double value)
    {
        return value < _minValue || value > _maxValue;
    }
}
