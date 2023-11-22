using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ResizeUI : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{    
    public Image img;
    private float UIimagemax;
    private RectTransform rect;
    public GameObject UIimage;
    public GameObject UIbolder;

    // Start is called before the first frame update
    void Start()
    {
        UIimagemax = img.transform.position.x;
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
        Debug.Log("继续");

        //       transform.position = new Vector3(Input.mousePosition.x, this.transform.position.y, this.transform.position.z);

         rect.offsetMin = new Vector2(rect.offsetMin.x + eventData.delta.x, rect.offsetMin.y);
        if (UIimage.transform.position.x < UIbolder.transform.position.x)
        {
            Debug.Log("超了");
            transform.position = new Vector3(UIbolder.transform.position.x, this.transform.position.y, this.transform.position.z);
            GetComponent<RectTransform>().sizeDelta = new Vector2(1881, 1040);
        }
        else if (UIimage.transform.position.x > UIimagemax)
        {
            Debug.Log("小了");
            transform.position = new Vector3(UIimagemax, this.transform.position.y, this.transform.position.z);
            GetComponent<RectTransform>().sizeDelta = new Vector2(582, 1040);
        }

    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("结束");
    }

}
