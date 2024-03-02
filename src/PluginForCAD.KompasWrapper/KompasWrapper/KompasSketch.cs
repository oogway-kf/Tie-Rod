using Kompas6API5;
using Kompas6Constants3D;
using PluginForCAD.Model;

namespace PluginForCAD.Wrapper
{
    /// <summary>
    /// Класс построения эскиза.
    /// </summary>
    public class KompasSketch
    {
        /// <summary>
        /// Документ 2D.
        /// </summary>
        private ksDocument2D _document2D;

        /// <summary>
        /// Интерфейс параметров эскиза.
        /// </summary>
        private ksSketchDefinition _sketchDefinition;

        /// <summary>
        /// Вернуть эскиз.
        /// </summary>
        public ksEntity Sketch { get; set; }

        /// <summary>
        /// Конструктор эскиза.
        /// </summary>
        /// <param name="part"></param>
        /// <param name="type">1 - ZY; 2 - ZX; 3 - XY.</param>
        public KompasSketch(ksPart part, int type, double offset = 0)
        {
            ksEntity plane = (ksEntity)part.NewEntity((short)Obj3dType.o3d_planeOffset);
            ksPlaneOffsetDefinition planeDefinition = (ksPlaneOffsetDefinition)plane.GetDefinition();
            if (type == 1)
            {
                planeDefinition.SetPlane(part.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ));
            }
            else if (type == 2)
            {
                planeDefinition.SetPlane(part.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));
            }
            else
            {
                planeDefinition.SetPlane(part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY));
            }

            planeDefinition.direction = true;
            planeDefinition.offset = offset;
            plane.Create();

            Sketch = (ksEntity)part.NewEntity((short)Obj3dType.o3d_sketch);
            _sketchDefinition = (ksSketchDefinition)Sketch.GetDefinition();
            _sketchDefinition.SetPlane(plane);
            Sketch.Create();
            _document2D = (ksDocument2D)_sketchDefinition.BeginEdit();
        }

        /// <summary>
        /// Закончить редактирование.
        /// </summary>
        public void EndEdit()
        {
            _sketchDefinition.EndEdit();
        }

        /// <summary>
        /// Создание круга на эскизе.
        /// </summary>
        /// <param name="center">Circle center.</param>
        /// <param name="radius">Circle radius.</param>
        public void CreateCircle(Point2D center, double radius)
        {
            _document2D.ksCircle(center.X, center.Y, radius, 1);
        }

        /// <summary>
        /// Создание линии на эскизе.
        /// </summary>
        /// <param name="start">Start coordinates.</param>
        /// <param name="end">End coordinates.</param>
        /// <param name="style">Line style.</param>
        public void CreateLineSeg(Point2D start, Point2D end, int style)
        {
            _document2D.ksLineSeg(start.X, start.Y, end.X, end.Y, style);
        }
    }
}