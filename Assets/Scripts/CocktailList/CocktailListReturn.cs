using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class CocktailListReturn : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(CloseListUI);
        }

        private void CloseListUI()
        {
            if (transform.parent.gameObject.activeSelf)
            {
                transform.parent.gameObject.SetActive(false);
            }
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}
