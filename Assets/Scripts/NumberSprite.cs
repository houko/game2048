using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class NumberSprite : MonoBehaviour
    {
        private Image image;


        private void awake()
        {
            image = GetComponent<Image>();
        }

        public void SetImage(int number)
        {
            image.sprite = ResourceManager.LoadSprite(number);
        }
    }
}