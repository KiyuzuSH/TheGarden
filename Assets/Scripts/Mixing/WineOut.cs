using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class WineOut : MonoBehaviour
    {
        private GameObject _wine;
        private GameObject _panelFullWarningInstance;
        public CupManager checker;
        private string _thisType;
        
        private void Start()
        {
            _thisType = name.Replace("Button", "");
            _wine = Resources.Load<GameObject>("Prefabs/Alcohol/" + _thisType);
            _panelFullWarningInstance = null;
            GetComponent<Button>().onClick.AddListener(OnPress);
        }

        private void OnPress()
        {
            if (checker.TotalSize >= 960f)
            {
                if (Mathf.Approximately(Time.timeScale, 1.0f) && _panelFullWarningInstance == null)
                {
                    _panelFullWarningInstance = Utilities.SpawnUIPanel(Panel.FullWarning);
                    Invoke(nameof(DisableFullWarning), 2);
                }
            }
            else
            {
                Instantiate(_wine, Utilities.TapMouth.position, Utilities.TapMouth.rotation);
                checker.OnePour(_thisType);
            }
        }

        private void DisableFullWarning()
        {
            Destroy(_panelFullWarningInstance);
            _panelFullWarningInstance = null;
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}