using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Game
{


    public class CSVRead : MonoBehaviour
    {
        [System.Serializable]
        public class Drink
        {
            //  public int number;
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
        string filename = "";
        public TextAsset textAssetData;

        public float size;
        public GameObject zeronotice;
        public int drinkcounter = 0;

        public string tagToDestroy = "songzi";

        public List<Drink> myDrinkList;


        //   public DrinkList myDrinkList = new DrinkList();

        void Start()
        {
            myDrinkList = new List<Drink>();
            //     filename = Application.dataPath + "/Excel/" + "/酒列表.csv";
            //           ReadCSV();

        }

        // Update is called once per frame
        void Update()
        {
            size = GameObject.Find("totalsize").GetComponent<totalsize>().total;
        }

        //  void ReadCSV()
        //  {
        //       string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

        //        int tableSize = data.Length / 12 - 1;
        //       myDrinkList.drink = new Drink[tableSize];

        //       for (int i = 0; i < tableSize; i++)
        //       {
        //          myDrinkList.drink[i] = new Drink();
        //          myDrinkList.drink[i].number = int.Parse(data[13 * (i + 1)]);
        //         myDrinkList.drink[i].name = data[12 * (i + 1)];
        //           myDrinkList.drink[i].weight = float.Parse(data[12 * (i + 1) + 1]);
        //           myDrinkList.drink[i].num1 = float.Parse(data[12 * (i + 1) + 2]);
        //          myDrinkList.drink[i].num2 = float.Parse(data[12 * (i + 1) + 3]);
        //           myDrinkList.drink[i].num3 = float.Parse(data[12 * (i + 1) + 4]);
        //           myDrinkList.drink[i].num4 = float.Parse(data[12 * (i + 1) + 5]);
        //          myDrinkList.drink[i].num5 = float.Parse(data[12 * (i + 1) + 6]);
        //         myDrinkList.drink[i].num6 = float.Parse(data[12 * (i + 1) + 7]);
        //          myDrinkList.drink[i].num7 = float.Parse(data[12 * (i + 1) + 8]);
        //         myDrinkList.drink[i].num8 = float.Parse(data[12 * (i + 1) + 9]);
        //       myDrinkList.drink[i].num9 = float.Parse(data[12 * (i + 1) + 10]);
        //        myDrinkList.drink[i].num10 = float.Parse(data[12 * (i + 1) + 11]);
        //    }
        //  }


        public void WriteCSV()
        {


            if (Time.timeScale == 1.0f)
            {
                if (size == 0)
                {
                    zeronotice.SetActive(true);
                    Invoke("deletel", 3);
                }
                else
                {

                    Text name1 = GameObject.Find("酒名-场外").GetComponent<CocktailName>().Word;
                    string names = name1.text;
                    float weight1 = size;
                    Drink newDrink = new Drink();
                    newDrink.name = names;
                    newDrink.weight = weight1;
                    newDrink.num1 = GameObject.Find("含量数据-红").GetComponent<ML>().text;
                    newDrink.num2 = GameObject.Find("含量数据-蓝").GetComponent<MLblue>().text;
                    newDrink.num3 = GameObject.Find("含量数据-绿").GetComponent<ML3>().text;
                    newDrink.num4 = GameObject.Find("含量数据-水").GetComponent<ML4>().text;
                    newDrink.num5 = 0;
                    newDrink.num6 = 0;
                    newDrink.num7 = 0;
                    newDrink.num8 = 0;
                    newDrink.num9 = 0;
                    newDrink.num10 = 0;
                    myDrinkList.Add(newDrink);
                    //      TextWriter tw = new StreamWriter(filename, true);

                    // tw.WriteLine(names + "," + weight1 + "," + GameObject.Find("含量数据-红").GetComponent<ML>().text + ","
                    //        + GameObject.Find("含量数据-蓝").GetComponent<MLblue>().text + "," + GameObject.Find("含量数据-绿").GetComponent<ML3>().text + ","
                    //       + GameObject.Find("含量数据-水").GetComponent<ML4>().text + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0);

                    //    tw.Close();

                    //newRowData = {number1,name1,weight1,num11,num12,num13,num14,num15,num16,num17,num18,num19,num101};
                    Debug.Log("保存完毕");
                   // DestroyObjects();
                    //SceneManager.LoadScene("SampleScene_wine");
                }

            }



        }

        public void DeleteCocktail()
        {
            myDrinkList.Clear();
            Debug.Log("删除完毕");
        }

        void DestroyObjects()
        {
            GameObject[] cocktails = GameObject.FindGameObjectsWithTag(tagToDestroy); // 获取特定标签的所有对象

            foreach (GameObject cocktail in cocktails)
            {
                Destroy(cocktail); // 销毁对象
            }
        }

        public void deletel()
        {

            zeronotice.SetActive(false);
        }

    }
}