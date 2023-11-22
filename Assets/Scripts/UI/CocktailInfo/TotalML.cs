using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalML : MonoBehaviour
{
    public float size;
    public Text Word;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        size = GameObject.Find("含量数据-红").GetComponent<ML>().size+ GameObject.Find("含量数据-蓝").GetComponent<MLblue>().size + GameObject.Find("含量数据-绿").GetComponent<ML3>().size + GameObject.Find("含量数据-水").GetComponent<ML4>().size;
        Word.text = size.ToString()+"ml";
    }
}
