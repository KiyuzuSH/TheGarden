using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class CocktailList : MonoBehaviour
    {
        [Tooltip("ListUI GO"+"\n"+"已调酒UI游戏物体")]
        public GameObject ListUI;

        private void Start()
            => GetComponent<Button>().onClick.AddListener(CallListUI);
    
        private void CallListUI()
        {
            if (!ListUI.activeSelf)
            {
                ListUI.SetActive(true);
            }
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}
