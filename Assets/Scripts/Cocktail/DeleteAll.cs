using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteAll : MonoBehaviour
            
{    // Start is called before the first frame update
    public bool cleared=false;public string tagToDestroy = "songzi";
 //   public GameObject a;
  //  public GameObject b;
  //  public GameObject c;
 //   public GameObject d;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void Press()
    {
        
        GameObject[] cocktails = GameObject.FindGameObjectsWithTag(tagToDestroy); // 获取特定标签的所有对象

        foreach (GameObject cocktail in cocktails)
        {
            Destroy(cocktail); // 销毁对象
        }

    }
}
