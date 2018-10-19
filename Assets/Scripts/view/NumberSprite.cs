using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    /// <inheritdoc />
    /// <summary>
    /// 定义精灵行为
    /// </summary>
    public class NumberSprite : MonoBehaviour
    {
        private Image image;

        /// <summary>
        /// 获取当前组件上上的图片
        /// </summary>
        private void Awake()
        {
            image = GetComponent<Image>();
           
        }

        /// <summary>
        /// 设置图片
        /// </summary>
        /// <param name="number"></param>
        public void SetImage(int number)
        {
            image.sprite = ResourceManager.LoadSprite(number);
        }
    }
}