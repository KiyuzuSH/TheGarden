using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalnew : MonoBehaviour
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
        size = GameObject.Find("totalsize").GetComponent<totalsize>().total;
        Word.text = size.ToString() + "ml";
    }
}
