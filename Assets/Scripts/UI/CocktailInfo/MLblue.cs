using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MLblue : MonoBehaviour
{
    public GameObject glass;
    public float size;
    public Text Word;
    public float text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         float total= GameObject.Find("体积数据").GetComponent<TotalML>().size;
        if(total!=0)
        {
            text = size / total * 100;
            Word.text = text.ToString() + "％";
        }
        else
        {
            Word.text = total.ToString() + "％";
        }       
    }
    public void SizeCheck()
    {
        Debug.Log("启动");
        GameObject totalsize = GameObject.Find("黑樱桃(Clone)");
        List<Transform> lst = new List<Transform>();
        if (totalsize != null)
        {
            foreach (Transform child in totalsize.transform)
            {
                lst.Add(child);
            }
        }
        for (int i = 0; i < lst.Count; i++)
        {
            if(GameObject.Find("totalsize").GetComponent<totalsize>().total >= 960)
            {

            }
            else
            {
            size += 1;
            }

        }
    }
}
