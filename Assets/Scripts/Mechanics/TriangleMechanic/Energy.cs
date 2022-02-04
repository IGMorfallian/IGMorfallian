using UnityEngine;
using UnityEngine.UI;

namespace Mechanics.TriangleMechanic
{
    public class Energy : MonoBehaviour
    {
        [SerializeField] private int countEnergyManager;
        [SerializeField] private Text text;

        public int CountEnergy => countEnergyManager;
    
        public void DecrementEnergy()
        {
            if (countEnergyManager > 0)
            {
                countEnergyManager--;
                text.text = "Energy :" + countEnergyManager;
            }
        }
    }
}
