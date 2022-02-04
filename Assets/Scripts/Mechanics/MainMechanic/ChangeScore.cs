using UnityEngine;
using UnityEngine.UI;

namespace Mechanics.MainMechanic
{
    public class ChangeScore : MonoBehaviour
    {
        [SerializeField] private MainMechanic mainMechanic;
        [SerializeField] private Text text;
    
        private int Score = 0;
        private void OnEnable()
        {
            mainMechanic.OnAddPoint += OnAddPoint;
        }

        private void OnDisable()
        {
            mainMechanic.OnAddPoint -= OnAddPoint;
        }
        private void OnAddPoint()
        {
            Score++;
            text.text = "Score :" + Score.ToString();
        }
    }
}

