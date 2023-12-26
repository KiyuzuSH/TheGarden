using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class WineOut : MonoBehaviour
    {
        private GameObject _wine;
        [Tooltip("The Warning of Too Much Alcohol Panel"
                 +"\n"+"酒满警告面板")]
        public GameObject fullWarningPanel;
        [Tooltip("Find \"Checker\" in Cup, with CupManager Class"
                 +"\n"+"使用杯子之Checker子物体，有CupManager类挂靠")]
        public CupManager checker;
        private string _thisType;
        
        private void Start()
        {
            _thisType = name.Replace("Button", "");
            _wine = Resources.Load<GameObject>("Prefabs/Alcohol/" + _thisType);
            GetComponent<Button>().onClick.AddListener(OnPress);
        }

        private void OnPress()
        {
            if (checker.TotalSize >= 960f)
            {
                if (Mathf.Approximately(Time.timeScale, 1.0f) && fullWarningPanel.activeSelf == false)
                {
                    fullWarningPanel.SetActive(true);
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
            fullWarningPanel.SetActive(false);
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}