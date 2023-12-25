using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CocktailName : MonoBehaviour
{
    public Text Word;
    public float totalsize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalsize = GameObject.Find("体积数据").GetComponent<TotalML>().size;
        if(GameObject.Find("含量数据-红").GetComponent<ML>().text>=90)
        {
            Word.text = "杜松子酒";
        }
        else if (GameObject.Find("含量数据-蓝").GetComponent<MLblue>().text >= 90)
        {
            Word.text = "黑樱桃利口酒";
        }
        else if (GameObject.Find("含量数据-绿").GetComponent<ML3>().text >= 90)
        {
            Word.text = "绿色夏翠思";
        }
        else if (GameObject.Find("含量数据-水").GetComponent<ML4>().text >= 90)
        {
            Word.text = "鲜榨柠檬汁";
        }
        else if(GameObject.Find("含量数据-红").GetComponent<ML>().text >= 24&& GameObject.Find("含量数据-蓝").GetComponent<MLblue>().text >= 24&& GameObject.Find("含量数据-绿").GetComponent<ML3>().text >= 24&& GameObject.Find("含量数据-水").GetComponent<ML4>().text >= 24)
        {
            Word.text = "临别赠言";
        }
        else if(totalsize==0)
        {
            Word.text = "";
        }
        else
        {
            Word.text = "混合酒";
        }
    }
}
