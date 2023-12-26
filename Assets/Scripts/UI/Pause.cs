using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Pause : MonoBehaviour
    {
        [Tooltip("PauseUI GO"+"\n"+"暂停UI游戏物体")]
        public GameObject PauseUI;

        private void Start() 
            => GetComponent<Button>().onClick.AddListener(PauseGame);
        
        private void PauseGame()
        {
            // TODO: if the mission list is not at forward
            if (!PauseUI.activeSelf)
            {
                Time.timeScale = 0.0f;
                PauseUI.SetActive(true);
            }
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}
