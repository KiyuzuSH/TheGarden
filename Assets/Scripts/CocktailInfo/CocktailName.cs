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
        totalsize = GameObject.Find("�������").GetComponent<TotalML>().size;
        if(GameObject.Find("��������-��").GetComponent<ML>().text>=90)
        {
            Word.text = "�����Ӿ�";
        }
        else if (GameObject.Find("��������-��").GetComponent<MLblue>().text >= 90)
        {
            Word.text = "��ӣ�����ھ�";
        }
        else if (GameObject.Find("��������-��").GetComponent<ML3>().text >= 90)
        {
            Word.text = "��ɫ�Ĵ�˼";
        }
        else if (GameObject.Find("��������-ˮ").GetComponent<ML4>().text >= 90)
        {
            Word.text = "��ե����֭";
        }
        else if(GameObject.Find("��������-��").GetComponent<ML>().text >= 24&& GameObject.Find("��������-��").GetComponent<MLblue>().text >= 24&& GameObject.Find("��������-��").GetComponent<ML3>().text >= 24&& GameObject.Find("��������-ˮ").GetComponent<ML4>().text >= 24)
        {
            Word.text = "�ٱ�����";
        }
        else if(totalsize==0)
        {
            Word.text = "";
        }
        else
        {
            Word.text = "��Ͼ�";
        }
    }
}
