using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Windows;

public class Task1 : MonoBehaviour
{
    async void NeedText()     //определение асинхронного метода, void - возвращаемый тип, async - модификатор для вызова асинхронного метода
    {
        Thread.Sleep(3000); //имитация продолжительной работы
        var text = await System.IO.File.ReadAllTextAsync(@"Assets\Text\Task1.txt"); //Выполнение асинхронного метода
        Debug.Log(text + " HELLO UNITY");
    }
    public void Awake()
    {
        NeedText();
    }
}
