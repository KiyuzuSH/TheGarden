using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Game {
public class CSVWine : MonoBehaviour
{
    public TextAsset textAssetData;
    [System.Serializable]

    public class Drink
    {
             public string name;
             public float weight;
            public float num1;
             public float num2;
             public float num3;
              public float num4;
              public float num5;
              public float num6;
              public float num7;
              public float num8;
             public float num9;
             public float num10;
    }
    [System.Serializable]
    public class DrinkList
    {
        public Drink[] drink;
    }
    public DrinkList myDrinkList = new DrinkList();

    // Start is called before the first frame update
    void Start()
    {
    //    ReadCSV();
    }
        void Update()
        {

            ReadCSV();
        }
      public void ReadCSV()
      {
            string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
    
           int tableSize = data.Length / 12 - 1;
           myDrinkList.drink = new Drink[tableSize];
    
            for (int i = 0; i < tableSize; i++)
            {
               myDrinkList.drink[i] = new Drink();
               myDrinkList.drink[i].name = data[12 * (i + 1)];
                myDrinkList.drink[i].weight = float.Parse(data[12 * (i + 1) + 1]);
                myDrinkList.drink[i].num1 = float.Parse(data[12 * (i + 1) + 2]);
               myDrinkList.drink[i].num2 = float.Parse(data[12 * (i + 1) + 3]);
                myDrinkList.drink[i].num3 = float.Parse(data[12 * (i + 1) + 4]);
               myDrinkList.drink[i].num4 = float.Parse(data[12 * (i + 1) + 5]);
               myDrinkList.drink[i].num5 = float.Parse(data[12 * (i + 1) + 6]);
               myDrinkList.drink[i].num6 = float.Parse(data[12 * (i + 1) + 7]);
               myDrinkList.drink[i].num7 = float.Parse(data[12 * (i + 1) + 8]);
               myDrinkList.drink[i].num8 = float.Parse(data[12 * (i + 1) + 9]);
               myDrinkList.drink[i].num9 = float.Parse(data[12 * (i + 1) + 10]);
               myDrinkList.drink[i].num10 = float.Parse(data[12 * (i + 1) + 11]);
           }
       }

}
}