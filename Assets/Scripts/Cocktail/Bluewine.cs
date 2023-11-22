using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluewine : MonoBehaviour
{
    public Transform makewine;
    public GameObject wine;
    public GameObject warning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Press()
    {
        if(GameObject.Find("totalsize").GetComponent<totalsize>().total >= 960)
        {
            if (Time.timeScale == 1.0f)
            {
                warning.SetActive(true);
                Invoke("deletel", 4);
            }
        }
        else
        {
        Instantiate(wine, makewine.position, makewine.rotation);
        }

    }
    public void deletel()
    {

        warning.SetActive(false);
    }
}
