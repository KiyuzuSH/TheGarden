using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game
{
    public class EmptyingCup : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(OnPress);
        }

        private void OnPress()
        {
            SceneManager.LoadScene("SampleScene");
        }
        
        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveAllListeners();
        }
    }
}
