using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private Button button;
    public GameObject pause;
    public float x;
    public GameObject rect1;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    void Update()
    {
        x = rect1.transform.position.x;
    }
    void OnClick()
    {
        if (x >= 1150)
        {
pause.SetActive(true);
        PauseGame();
        }
            
    }
    public void PauseGame()
    {
        Time.timeScale = 0.0f;
    }

}
