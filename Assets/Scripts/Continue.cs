using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Continue : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(ContinueGame);
        }

        private void ContinueGame()
        {
            // TODO: disable pause panel
            if (Pause.PanelPauseInstance != null)
            {
                Destroy(Pause.PanelPauseInstance);
                Pause.PanelPauseInstance = null;
                Time.timeScale = 1.0f;
            }
        }
        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}
