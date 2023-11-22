using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totalsize : MonoBehaviour
{
    public GameObject totalsize1;
    public float total;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sizecheck()
    {
        totalsize1 = GameObject.FindWithTag("songzi");
        List<Transform> lst = new List<Transform>();
        if(total==960)
        {
            total = 960;
        }
        else
        {
        if (totalsize1 != null)
        {
            foreach (Transform child in totalsize1.transform)
            {
                lst.Add(child);
            }
        }
        for (int i = 0; i < lst.Count; i++)
        {
            total += 1;
        }
        }

    }
}
