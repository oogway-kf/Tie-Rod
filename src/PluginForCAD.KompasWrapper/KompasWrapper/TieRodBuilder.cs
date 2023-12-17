using KompasAPI7;
using PluginForCAD.Model;
using PluginForCAD.Wrapper;

namespace PluginForCAD.Wrapper
{
    /// <summary>
    /// Класс построения рейки.
    /// </summary>
    public class TieRodBuilder
    {
        /// <summary>
        /// Оболочка Компас.
        /// </summary>
        private KompasWrapper _wrapper = new KompasWrapper();

        /// <summary>
        /// Создание рейки.
        /// </summary>
        /// <param name="TieRodParameters">Параметры рейки.</param>
        public void BuildTieRod(TieRodParameters TieRodParameters)
        {
            _wrapper.StartKompas();
            _wrapper.CreateDocument();
            _wrapper.SetProperties();

            var bigPartRadius = 
                TieRodParameters.GetParameterValue(ParametersType.BigPartDiameter) / 2;
            var smallPartRadius = 
                TieRodParameters.GetParameterValue(ParametersType.SmallPartDiameter) / 2;
            var bigPartLength = 
                TieRodParameters.GetParameterValue(ParametersType.BigPartLength);
            var smallPartLength =
                TieRodParameters.GetParameterValue(ParametersType.SmallPartLength);
            var ChamferLength = 
                TieRodParameters.GetParameterValue(ParametersType.ChamferLength);
            BuildTieRodBody(bigPartRadius, smallPartRadius, bigPartLength, smallPartLength);
            _wrapper.CreateChamfer(false, ChamferLength, ChamferLength,
                bigPartLength + smallPartLength, bigPartRadius, 0);
        }

        /// <summary>
        /// Построение скетча с формой рейки.
        /// </summary>
        /// <param name="bigPartRadius">Радиус большей части.</param>
        /// <param name="smallPartRadius">Радиус малой части.</param>
        /// <param name="bigPartLength"></param>
        /// <param name="smallPartLength"></param>
        private void BuildTieRodBody(double bigPartRadius, double smallPartRadius,
            double bigPartLength, double smallPartLength)
        {
            //Осевая линия
            var centralStart = new Point2D(-250, 0);
            var centralEnd = new Point2D(250, 0);
            //Создание скетча на осях
            var sketch = _wrapper.CreateSketch(2);
            sketch.CreateLineSeg(centralStart, centralEnd, 3);
            //Точки для построения линий.
            var pointStart = new Point2D(0, 0);
            var pointSmallPartRadius = new Point2D(0, smallPartRadius);
            var pointSmallPartLength = new Point2D(smallPartLength, smallPartRadius);
            var pointRadiusDifference = new Point2D(smallPartLength, bigPartRadius);
            var pointBigPartLength = new Point2D(bigPartLength + smallPartLength,bigPartRadius);
            var pointBigPartRadius = new Point2D(bigPartLength + smallPartLength, 0); 
     
            sketch.CreateLineSeg(pointStart, pointSmallPartRadius, 1);
            sketch.CreateLineSeg(pointSmallPartRadius, pointSmallPartLength, 1);
            sketch.CreateLineSeg(pointSmallPartLength, pointRadiusDifference, 1);
            sketch.CreateLineSeg(pointRadiusDifference, pointBigPartLength, 1);
            sketch.CreateLineSeg(pointBigPartLength, pointBigPartRadius, 1);

            sketch.EndEdit();
            _wrapper.ExtrudeRotation360(sketch);
        }

    }
}
