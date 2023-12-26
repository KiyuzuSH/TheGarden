using TMPro;
using UnityEngine;

namespace Game
{
    public class CocktailUIDebug : MonoBehaviour
    {
        public TextMeshProUGUI volume;
        public TextMeshProUGUI GinPer;
        public TextMeshProUGUI CherryPer;
        public TextMeshProUGUI WinePer;
        public TextMeshProUGUI WaterPer;
        public CupManager checker;

        private void Start()
        {
            volume.text = "0 mL";
            GinPer.text = "0 %";
            CherryPer.text = "0 %";
            WinePer.text = "0 %";
            WaterPer.text = "0 %";
        }

        private void Update()
        {
            volume.text = checker.TotalSize + " mL";
            GinPer.text = checker.GinPer + " %";
            CherryPer.text = checker.CherryPer + " %";
            WinePer.text = checker.WinePer + " %";
            WaterPer.text = checker.WaterPer + " %";
        }
    }
}
