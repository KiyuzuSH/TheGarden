using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Continue : MonoBehaviour
    {
        private GameObject _pauseUI;
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(ContinueGame);
            _pauseUI = gameObject.GetComponentInParent<GameObject>();
        }

        private void ContinueGame()
        {
            if (_pauseUI.activeSelf)
            {
                _pauseUI.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}
