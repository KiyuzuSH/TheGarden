using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Game
{
    public class DialogueManager : MonoBehaviour
    {
        /// 对话文本文件csv
        public TextAsset dialogDataFile;

        public TMP_Text nameText;
        public TMP_Text dialogText;

        public SpriteRenderer spriteLeft;
        public SpriteRenderer spriteRight;

        /// 角色图片列表
        public List<Sprite> sprites = new List<Sprite>();

        /// 角色名字与立绘对应
        private Dictionary<string, Sprite> imageDic = new Dictionary<string, Sprite>();

        /// 当前对话索引
        private int dialogIndex;

        /// 对话文本，按行
        private string[] dialogRows;

        [Tooltip("继续按钮\nThe Button to Continue the dialogue")]
        public Button buttonNext;

        /// 预制体
        [Tooltip("选择按钮的预制体\nThe Prefab of Choice Button")]
        public GameObject buttonChoice;

        /// Grid Layout Group Transform
        [Tooltip("按钮的Grid Layout Group\nThe Grid Layout Group of Buttons")]
        public Transform gridButton;

        private void Awake()
        {
            imageDic["警员"] = sprites[0];
        }

        private void Start()
        {
            ReadText(dialogDataFile);
            ShowDialogRow();
            buttonNext.onClick.AddListener(OnNextClick);
        }
        
        private void OnNextClick()
        {
            ShowDialogRow();
        }

        private void OnDestroy()
        {
            buttonNext.onClick.RemoveAllListeners();
        }

        private void ShowDialogRow()
        {
            for (var i = 0; i < dialogRows.Length; i++)
            {
                var cells = dialogRows[i].Split(',');
                if(cells[0]=="ID") continue;
                if(int.Parse(cells[0]) == dialogIndex)
                {
                    switch (cells[1])
                    {
                        case "#":
                            UpdateText(cells[3], cells[5]);
                            // UpdateImage(cells[3],cells[4]);
                            dialogIndex = int.Parse(cells[2]);
                            buttonNext.gameObject.SetActive(true);
                            break;
                        case "&":
                            buttonNext.gameObject.SetActive(false);
                            GenerateChoice(i);
                            break;
                        case "!":
                            
                            break;
                        case "END":
                            Debug.Log("Story Script Ends Here");
                            buttonNext.gameObject.SetActive(false);
                            break;
                    }
                    break;
                }
            }
        }

        #region Basic

        private void ReadText(TextAsset _textAsset)
        {
            dialogRows = _textAsset.text.Split('\n');
            // foreach (var row in dialogRows)
            // {
            //     string[] cell = row.Split(',');
            // }
            Debug.Log("Succeed to read");
        }

        private void UpdateText(string _name, string _text)
        {
            nameText.text = _name;
            dialogText.text = _text;
        }

        private void UpdateImage(string _name, string _pos)
        {
            if (_pos == "Left")
                spriteLeft.sprite = imageDic[_name];
            else if (_pos == "Right") spriteRight.sprite = imageDic[_name];
        }

        #endregion

        #region ChoiceButton

        private void GenerateChoice(int _index)
        {
            var cells = dialogRows[_index].Split(',');
            if (cells[1] == "&")
            {
                var button = Instantiate(buttonChoice, gridButton);
                button.GetComponentInChildren<TMP_Text>().text = cells[5];
                button.GetComponent<Button>().onClick.AddListener
                (
                    delegate { OnChoiceClick(int.Parse(cells[2])); }
                );
                GenerateChoice(_index + 1);
            }
        }

        private void OnChoiceClick(int _id)
        {
            dialogIndex = _id;
            ShowDialogRow();
            for (var i = 0; i < gridButton.childCount; i++) Destroy(gridButton.GetChild(i).gameObject);
        }

        #endregion


    }
}
