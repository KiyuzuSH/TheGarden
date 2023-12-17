using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CheckCocktail : MonoBehaviour
{
    public GameObject cocktailinfo;
    public Image missionpage;
    public float x;
    public GameObject rect1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = rect1.transform.position.x;
    }

    void OnMouseEnter()
    {
        if(Time.timeScale==1.0f)
        {
        if(x == 2261)
            {
        cocktailinfo.SetActive(true);
            }

        }

    }
    void OnMouseExit()
    {
        cocktailinfo.SetActive(false);
    }
}
