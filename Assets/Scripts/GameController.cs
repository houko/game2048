using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;


/// <inheritdoc />
/// <summary>
/// 控制游戏逻辑
/// </summary>
public class GameController : MonoBehaviour
{
    /// <summary>
    /// 创建游戏初始格子
    /// </summary>
    private void Start()
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
    /// 根据坐标创建精灵格子
    /// </summary>
    /// <param name="r">x坐标</param>
    /// <param name="c">y坐标</param>
    private void CreateSprite(int r, int c)
    {
        GameObject go = new GameObject(string.Format("{0},{1}", r, c));
        go.AddComponent<Image>();
        NumberSprite numberSprite = go.AddComponent<NumberSprite>();
        numberSprite.SetImage(0);
        go.transform.SetParent(transform, false);
    }
}