using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Put : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public Image img;
//    public float UIimagemax;
    private float UIimagemin;
    private RectTransform rect;
    public GameObject UIimage;
    public GameObject UIbolder;
    // Start is called before the first frame update
    void Start()
    {
        UIimagemin = img.transform.position.x;
        rect = img.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("开始");
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (Time.timeScale == 1.0f)
        {
            Debug.Log("继续");
            GetComponent<RectTransform>().sizeDelta = new Vector2(1881, 1040);
            rect.offsetMin = new Vector2(rect.offsetMin.x + eventData.delta.x, rect.offsetMin.y);
            if (UIimage.transform.position.x > UIimagemin)
            {
                Debug.Log("超了");
                GetComponent<RectTransform>().sizeDelta = new Vector2(1881, 1040);
                transform.position = new Vector3(UIimagemin, this.transform.position.y, this.transform.position.z);
            }
            else if (UIimage.transform.position.x < UIbolder.transform.position.x)
            {
                Debug.Log("小了");
                GetComponent<RectTransform>().sizeDelta = new Vector2(1881, 1040);
                transform.position = new Vector3(UIbolder.transform.position.x, this.transform.position.y, this.transform.position.z);
            }
        }
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Time.timeScale = 1.0f;
        Debug.Log("结束");
    }
}
