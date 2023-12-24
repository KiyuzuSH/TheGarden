using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class CocktailUI : MonoBehaviour
    {
        public TextMeshProUGUI cocktailName;
        public TextMeshProUGUI volume;
        public CupManager checker;
        
        private void Start()
        {
            cocktailName.text = "";
            volume.text = "0 mL";
        }

        private void Update()
        {
            cocktailName.text = checker.CocktailName;
            volume.text = checker.TotalSize + " mL";
        }
    }
}
