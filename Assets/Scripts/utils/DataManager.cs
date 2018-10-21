using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class DataManager : MonoBehaviour
    {
        public static void ClearData()
        {
            PlayerPrefs.DeleteAll();
        }

        public static void ClearDataByKey(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }
    }
}