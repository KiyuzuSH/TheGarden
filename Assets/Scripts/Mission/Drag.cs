using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class Drag : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
    {
        private Vector3 _right;
        private Vector3 _center;

        private void Start()
        {
            _right = transform.position;
            _center = Utilities.CanvasBorder.transform.position;
        }

        public void OnBeginDrag(PointerEventData eventData) { }

        public void OnDrag(PointerEventData eventData)
        {
            Time.timeScale = 0.0f;
            if (Mathf.Approximately(Time.timeScale, 0.0f))
            {
                transform.position += new Vector3(eventData.delta.x,0,0);
                if (transform.position.x < _center.x)
                {
                    // Debug.LogWarning("Too Left");
                    transform.position = _center;
                }
                else if (transform.position.x > _right.x)
                {
                    // Debug.LogWarning("Too Right");
                    transform.position = _right;
                }
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Time.timeScale = 1.0f;
        }
    }
}
