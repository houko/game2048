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
    private GameCore gameCore;

    private NumberSprite[,] numberSpriteArray;


    private void Awake()
    {
        numberSpriteArray = new NumberSprite[4, 4];
        GenerateNewNumber();
        GenerateNewNumber();
    }


    /// <summary>
    /// 创建游戏初始格子
    /// </summary>
    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                CreateSprite(i, j);
            }
        }
    }


    /// <summary>
    /// 生成新数字
    /// </summary>
    private void GenerateNewNumber()
    {
        Location location;
        int number;
        gameCore.GenerateNumber(out location, out number);
        numberSpriteArray[location.RIndex, location.CIndex].SetImage(number);
    }


    /// <summary>
    /// 根据坐标创建精灵格子
    /// </summary>
    /// <param name="r">x坐标</param>
    /// <param name="c">y坐标</param>
    private void CreateSprite(int r, int c)
    {
        GameObject go = new GameObject(string.Format("{0},{1}", r, c));
        go.transform.SetParent(transform, false);
        
        Image unused = go.AddComponent<Image>();
        NumberSprite action = go.AddComponent<NumberSprite>();
        numberSpriteArray[r, c] = action;
        action.SetImage(0);
    }
}