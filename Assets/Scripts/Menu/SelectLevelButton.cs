using System;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    public class SelectLevelButton : MonoBehaviour
    {
        public event Action<int> OnLevelButtonPressed; 

        [SerializeField] private Button button;
        [SerializeField] private Text text;
    
        private int _levelIndex;

        public void SetLevelIndex(int value)
        {
            _levelIndex = value;
            text.text = (value + 1).ToString();
        }

        private void OnEnable()
        {
            button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            OnLevelButtonPressed?.Invoke(_levelIndex);
        }
    }
}
