using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteAll : MonoBehaviour
{    // Start is called before the first frame update
    public bool cleared=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void Press()
    {
        Application.LoadLevel("SampleScene_wine");
    }
}
