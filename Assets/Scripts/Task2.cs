using System;
using System.Collections;
using UnityEngine;
using File = System.IO.File;

public class Task2 : MonoBehaviour

{
    
    // Это метод Awake(), который вызывается один раз при запуске игры для инициализации объекта.
    //     Здесь мы используем метод StartCoroutine(), чтобы запустить корутину GetEnumerator().
    private void Awake()
    {
        StartCoroutine(GetEnumerator());
    }
    // Это корутина GetEnumerator(), которая считывает содержимое файла textTask2.txt и выводит его в консоль.
    // Мы используем статический метод ReadAllText() класса File, чтобы прочитать содержимое файла в строку file.
    // Затем мы используем метод Debug.Log() класса UnityEngine для вывода строки file в консоль.
    // В конце метода мы используем оператор yield return null для приостановки выполнения корутины до следующего кадра игры.
    // Итак, в целом, данный код использует корутину GetEnumerator() для чтения содержимого файла textTask2.txt и выводит его в консоль.
    // Метод Awake() вызывает эту корутину при запуске игры.
    // ReSharper disable Unity.PerformanceAnalysis
    public IEnumerator GetEnumerator()
    {
        String file = File.ReadAllText(@"Assets\Text\Task2.txt");
        Debug.Log(file);
        yield return null;
    }
    
    
}