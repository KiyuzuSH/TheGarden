using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CheckCocktail : MonoBehaviour
{
    public GameObject cocktailinfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if(Time.timeScale==1.0f)
        {
        cocktailinfo.SetActive(true);
        }

    }
    void OnMouseExit()
    {
        cocktailinfo.SetActive(false);
    }
}
