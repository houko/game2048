using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    /// <summary>
    /// 调用创建精灵图
    /// </summary>
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                CreateSprite(i + 1, j + 1);
            }
        }
    }


    /// <summary>
    /// 创建精灵格子
    /// </summary>
    /// <param name="r">x坐标</param>
    /// <param name="c">y坐标</param>
    private void CreateSprite(int r, int c)
    {
        GameObject go = new GameObject(string.Format("{0},{1}", r, c));
        go.AddComponent<Image>();
        go.transform.SetParent(transform);
    }
}