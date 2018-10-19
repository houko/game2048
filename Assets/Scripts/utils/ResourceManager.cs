using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    /// <inheritdoc />
    /// <summary>
    /// 资源读取管理类
    /// </summary>
    public class ResourceManager : MonoBehaviour
    {
        private static readonly Dictionary<int, Sprite> Sprites;


        /// <summary>
        /// 构造方法
        /// </summary>
        static ResourceManager()
        {
            Sprites = new Dictionary<int, Sprite>();
            Sprite[] sprites = Resources.LoadAll<Sprite>("2048Atlas");
            foreach (var item in sprites)
            {
                Sprites.Add(int.Parse(item.name), item);
            }
        }

        /// <summary>
        /// 返回精灵
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Sprite LoadSprite(int num)
        {
            return Sprites[num];
        }
    }
}