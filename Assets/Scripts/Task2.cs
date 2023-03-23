using System;
using System.Collections;
using UnityEngine;

public class Task2 : MonoBehaviour

{
    private void Awake()
    {
        StartCoroutine(Text());  //запуск сопрограммы
    }

    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator Text()
    {
        var text = System.IO.File.ReadAllText(@"Assets\Text\Task2.txt");
        Debug.Log(text + " HELLO UNITY-2");
        yield return null; //закрытие сопрограммы
    }
}