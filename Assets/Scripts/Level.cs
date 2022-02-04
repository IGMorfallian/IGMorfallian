using System;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public event Action OnMenuButtonPressed;
    
    [SerializeField] private Button menuButton;

    private void OnEnable()
    {
        menuButton.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        menuButton.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        OnMenuButtonPressed?.Invoke();
    }
}
