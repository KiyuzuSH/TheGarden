using System.IO;
using System.Text;
using System.Xml.Serialization;
using UnityEngine;

namespace Game
{
    public class Utilities : MonoBehaviour
    {
        private static Transform _canvas;
        public static Transform Canvas
        {
            get
            {
                if (_canvas == null)
                    _canvas = GameObject.Find("Canvas").transform;
                return _canvas;
            }
        }

        private static GameObject _canvasBorder;
        public static GameObject CanvasBorder
        {
            get
            {
                if (_canvasBorder == null)
                    _canvasBorder = GameObject.Find("ElementBorder");
                return _canvasBorder;
            }
        }

        private static Transform _tapMouth;
        public static Transform TapMouth
        {
            get
            {
                if (_tapMouth == null)
                    _tapMouth = GameObject.Find("TapMouth").transform;
                return _tapMouth;
            }
        }

        public static void SaveData(GameData data)
        {
            string fileName=Consts.DataPath;

            Stream stream = new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.Write);

            StreamWriter sw = new StreamWriter(stream,Encoding.UTF8);
            XmlSerializer xmlSerializer = new XmlSerializer(data.GetType());
            xmlSerializer.Serialize(sw, data);
            sw.Close();
            stream.Close();
        }
        
        public static GameData LoadData()
        {
            GameData data=new GameData();
            Stream stream = new FileStream(Consts.DataPath,FileMode.Open,FileAccess.Read);
            // 忽略标记 = true
            StreamReader sr = new StreamReader(stream, true);
            XmlSerializer xmlSerializer = new XmlSerializer(data.GetType());
            data = xmlSerializer.Deserialize(sr) as GameData;
            stream.Close();
            sr.Close();
            return data;
        }
        
    }
}
