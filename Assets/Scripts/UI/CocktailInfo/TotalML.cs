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
        size = GameObject.Find("��������-��").GetComponent<ML>().size+ GameObject.Find("��������-��").GetComponent<MLblue>().size + GameObject.Find("��������-��").GetComponent<ML3>().size + GameObject.Find("��������-ˮ").GetComponent<ML4>().size;
        Word.text = size.ToString()+"ml";
    }
}
