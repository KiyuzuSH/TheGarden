using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CocktaiList : MonoBehaviour
{
    private Button button;
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    void OnClick()
    {

            pause.SetActive(true);


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
