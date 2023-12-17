using Kompas6API5;
using Kompas6Constants3D;
using KompasAPI7;
using System.Runtime.InteropServices;

namespace PluginForCAD.Wrapper
{
    internal class KompasWrapper
    {
        /// <summary>
        /// Объект Компас API.
        /// </summary>
        private KompasObject _kompas;

        /// <summary>
        /// Модель.
        /// </summary>
        private ksPart _part;

        /// <summary>
        /// Документ Компас 3D.
        /// </summary>
        private ksDocument3D _document;


        /// <summary>
        /// Старт Компас 3D.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void StartKompas()
        {
            try
            {
                if (_kompas != null)
                {
                    _kompas.Visible = true;
                    _kompas.ActivateControllerAPI();
                }

                if (_kompas != null) return;
                {
                    var kompasType = Type.GetTypeFromProgID("KOMPAS.Application.5");
                    _kompas = (KompasObject)Activator.CreateInstance(kompasType);
                    StartKompas();
                    if (_kompas == null)
                    {
                        throw new Exception("Can't open Kompas3D.");
                    }
                }
            }
            catch (COMException)
            {
                _kompas = null;
                StartKompas();
            }
        }

        /// <summary>
        /// Создать документ Компас 3D.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void CreateDocument()
        {
            try
            {
                _document = (ksDocument3D)_kompas.Document3D();
                _document.Create();
                _document = (ksDocument3D)_kompas.ActiveDocument3D();
            }
            catch
            {
                throw new ArgumentException("Не удалось создать деталь.");
            }
        }

        /// <summary>
        /// Установить свойства: цвет и имя.
        /// </summary>
        public void SetProperties()
        {
            _part = (ksPart)_document.GetPart((short)Part_Type.pTop_Part);
            _part.name = "TieRod";
            _part.SetAdvancedColor(1488, 0.8, 0.8, 0.8, 0.8);
            _part.Update();
        }

        /// <summary>
        /// Создать эскиз.
        /// </summary>
        /// <param name="type">Плоскость эскиза.</param>
        /// <param name="offset">Отступ эскиза от начала координат.</param>
        /// <returns>Эскиз Компас 3D.</returns>
        public KompasSketch CreateSketch(int type, double offset = 0)
        {
            return new KompasSketch(_part, type, offset);
        }


        /// <summary>
        /// Выдавливание вращением на 360 градусов.
        /// </summary>
        /// <param name="kompasSketch">Скетч.</param>
        public void ExtrudeRotation360(KompasSketch kompasSketch)
        {
            ksEntity bossRotated = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_bossRotated);
            ksBossRotatedDefinition bossRotatedDefinition = (ksBossRotatedDefinition)bossRotated.GetDefinition();
            bossRotatedDefinition.directionType = (short)Direction_Type.dtNormal;
            bossRotatedDefinition.SetSketch(kompasSketch.Sketch);
            bossRotatedDefinition.SetSideParam(true, 360);
            bossRotated.Create();
        }

        /// <summary>
        /// Создать фаску.
        /// </summary>
        /// <param name="shift"></param>
        /// <param name="chamferDistance"></param>
        /// <param name="edgeCoordinate"></param>
        public void CreateChamfer(bool transfer, double distanceOne, double distanceTwo,
            double x, double y, double z)
        {
            ksEntity sketch = _part.NewEntity((short)Obj3dType.o3d_chamfer);
            ksChamferDefinition definition = sketch.GetDefinition();
            definition.tangent = true;
            definition.SetChamferParam(transfer,
                distanceOne, distanceTwo);
            ksEntityCollection array = definition.array();
            ksEntityCollection collection =
                _part.EntityCollection((short)Obj3dType.o3d_edge);
            collection.SelectByPoint(x, y, z);
            ksEntity edge = collection.Last();
            array.Add(edge);
            sketch.Create();
        }

    }
}
