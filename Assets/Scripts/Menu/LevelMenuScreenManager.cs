using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class LevelMenuScreenManager : MonoBehaviour
    {
        [SerializeField] private Level[] levels;
        [SerializeField] private SelectLevelButton buttonPrefab;
        [SerializeField] private Transform root;
        [SerializeField] private Canvas canvas;
    
        private Level _currentLevel;
        private List<SelectLevelButton> _levelButtons = new List<SelectLevelButton>();

        private void Awake()
        {
            for (var i = 0; i < levels.Length; i++)
            {
                var button = Instantiate(buttonPrefab, root);
                button.SetLevelIndex(i);
                _levelButtons.Add(button);
            }
        }

        private void OnEnable()
        {
            foreach (var levelButton in _levelButtons)
            {
                levelButton.OnLevelButtonPressed += OnLevelSelect;
            }
        }

        private void OnDisable()
        {
            foreach (var levelButton in _levelButtons)
            {
                levelButton.OnLevelButtonPressed -= OnLevelSelect;
            }
        }

        private void OnLevelSelect(int levelIndex)
        {
            SetLevel(levelIndex);
            canvas.gameObject.SetActive(false);
        }

        private void SetLevel(int levelIndex)
        {
            _currentLevel = Instantiate(levels[levelIndex]);
            _currentLevel.OnMenuButtonPressed += OnMenuButtonPressedHandler;
        }

        private void OnMenuButtonPressedHandler()
        {
            if (_currentLevel != null)
            {
                _currentLevel.OnMenuButtonPressed -= OnMenuButtonPressedHandler;
                Destroy(_currentLevel.gameObject);
            }
        
            canvas.gameObject.SetActive(true);
        }
    }
}
