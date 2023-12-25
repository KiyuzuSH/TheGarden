using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Pause : MonoBehaviour
    {
        public static GameObject PanelPauseInstance;

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(PauseGame);
            PanelPauseInstance = null;
        }

        private void PauseGame()
        {
            // TODO: if the mission list is not at forward
            if (PanelPauseInstance == null)
            {
                Time.timeScale = 0.0f;
                PanelPauseInstance = Utilities.SpawnUIPanel(Panel.Pause);
            }
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}
