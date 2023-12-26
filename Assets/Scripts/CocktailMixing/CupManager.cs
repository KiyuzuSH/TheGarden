using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

namespace Game
{
    public class CupManager : MonoBehaviour
    {
        // Size of one kind of alcohol
        private float SizeGin { get; set; }
        public float GinPer { get; private set; }
        private float SizeCherry { get; set; }
        public float CherryPer { get; private set; }
        private float SizeWine { get; set; }
        public float WinePer { get; private set; }
        private float SizeWater { get; set; }
        public float WaterPer { get; private set; }
        public float TotalSize { get; private set; }
        public string CocktailName { get; private set; }
        [Tooltip("The Mission Panel"
                 +"\n"+"任务面板")]
        public RectTransform missionPanel;
        [Tooltip("The Cocktail Info Panel, shows when mouse on that"
                 +"\n" +"鸡尾酒信息面板，鼠标Hover时显示。")]
        public GameObject cocktailPanel;

        private void Start()
        {
            CupInitialization();
            cocktailPanel.SetActive(false);
        }
        
        private void OnMouseEnter()
        {
            if (Mathf.Approximately(Time.timeScale, 1.0f) && !cocktailPanel.activeSelf)
                if (missionPanel.localPosition.x >= 1424f)
                    cocktailPanel.SetActive(true);
        }

        private void OnMouseExit() => cocktailPanel.SetActive(false);
        
        private void CupInitialization()
        {
            SizeGin = 0f;
            GinPer = 0f;
            SizeCherry = 0f;
            CherryPer = 0f;
            SizeWine = 0f;
            WinePer = 0f;
            SizeWater = 0f;
            WaterPer = 0f;
            TotalSize = 0f;
        }

        private void SetAlcoholSize(string kind)
        {
            switch (kind)
            {
                default:
                    break;
                case "Gin":
                    SizeGin = GameObject.FindGameObjectsWithTag("Gin").Length * 12;
                    break;
                case "BlackCherry":
                    SizeCherry = GameObject.FindGameObjectsWithTag("BlackCherry").Length * 12;
                    break;
                case "RedWine":
                    SizeWine = GameObject.FindGameObjectsWithTag("RedWine").Length * 12;
                    break;
                case "Water":
                    SizeWater = GameObject.FindGameObjectsWithTag("Water").Length * 12;
                    break;
            }
        }
        
        private void SetTotalSize() 
            => TotalSize = GameObject.FindGameObjectsWithTag("AlcoholLiquid").Length;

        private void PercentCalculator()
        {
            if (Mathf.Approximately(TotalSize, 0f))
            {
                CupInitialization();
            }
            else if (TotalSize > 0f)
            {
                GinPer = SizeGin / TotalSize * 100;
                CherryPer = SizeCherry / TotalSize * 100;
                WinePer = SizeWine / TotalSize * 100;
                WaterPer = SizeWater / TotalSize * 100;
            }
        }

        private void NameDefiner()
        {
            if (Mathf.Approximately(TotalSize, 0f))
            {
                CocktailName = "";
            }
            else if (GinPer >= 24
                     && CherryPer >= 24
                     && WinePer >= 24
                     && WaterPer >= 24)
            {
                CocktailName =  "临别赠言";
            }
            else if (GinPer >= 90)
            {
                CocktailName =  "杜松子酒=金酒";
            }
            else if (CherryPer >= 90)
            {
                CocktailName =  "黑樱桃利口酒";
            }
            else if (WinePer >= 90)
            {
                CocktailName =  "红酒 or 绿色夏翠思";
            }
            else if (SizeWater >= 90)
            {
                CocktailName =  "水 or 柠檬汁";
            }
            else
            {
                CocktailName =  "混合酒";
            }
            
        }

        public void OnePour(string alKind)
        {
            SetAlcoholSize(alKind);
            SetTotalSize();
            PercentCalculator();
            NameDefiner();
        }
        
    }
}
