using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Game;
    public class CocktailListInfo : MonoBehaviour
    {
        public TMP_Text cocktaillist;
        public CSVRead cocktailinfo;
    public List<CSVRead.Drink> drinks;
        // Start is called before the first frame update
        
        public void Update()
        {
            
               drinks = GameObject.Find("Excel").GetComponent<CSVRead>().myDrinkList;
            
            cocktaillist.text = "";
            for(int i=0;i<drinks.Count;i++)
           {
               cocktaillist.text += "�������ƣ�"+drinks[i].name + "\n";
               cocktaillist.text += "����"+drinks[i].weight + "ml"+"\n";
            }
        }
    }
