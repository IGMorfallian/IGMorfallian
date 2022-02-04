
using UnityEngine;

namespace Mechanics.MainMechanic
{
    public class SizeSphere : MonoBehaviour
    {
        [SerializeField] private int sizeSphere;
        private void OnValidate()
        {
            transform.localScale = new Vector3(sizeSphere, sizeSphere, 1);
        }
    
        public int SizeOfShape
        {
            get => sizeSphere;
            set
            {
            
            }
        }
    }
}
