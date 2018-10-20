using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace test
{
    public class CollectionsDemo : MonoBehaviour
    {
        private Stack stack = new Stack();


        private void Start()
        {
            stack.Push("主菜单");
            stack.Push("选项");
            stack.Push("游戏选项");
            stack.Push("难度调节");
            stack.Push("一般");


            while (stack.Count > 0)
            {
                print(stack.Pop());
            }
        }
    }
}