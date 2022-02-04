
using UnityEngine;

namespace Mechanics.MainMechanic
{
    public class SizeCube : MonoBehaviour
    {
        [SerializeField] private int sizeCube = 1;
        private void OnValidate()
        {
            SetScaleCube(sizeCube);
        }

        public int SizeOfShape
        {
            get => sizeCube;
            set => sizeCube -= value;
        }

        public void SetScaleCube(int sizeCube)
        {
            var scale = Mathf.Sqrt(Mathf.Pow(sizeCube, 2) + Mathf.Pow(sizeCube, 2)) / 2;
            transform.localScale = new Vector3(scale, scale, 1); 
        }
    }
}
