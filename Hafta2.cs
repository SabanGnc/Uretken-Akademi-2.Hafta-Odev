using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hafta2 : MonoBehaviour
{
    void Start()
    {
        bolenleriBul(1, 20);
    }

    public void bolenleriBul(int ilksayi, int ikincisayi)
    {
        UnityEngine.Debug.Log("1. a�ama:");
        string a�ama1 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            a�ama1 += i + "-";
        }
        UnityEngine.Debug.Log(a�ama1.TrimEnd('-'));

        UnityEngine.Debug.Log("\n2. a�ama:");
        string a�ama2 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 2 == 0)
                a�ama2 += i + "-";
        }
        UnityEngine.Debug.Log(a�ama2.TrimEnd('-'));

        UnityEngine.Debug.Log("\n3. a�ama:");
        string a�ama3 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 3 == 0)
                a�ama3 += i + "-";
        }
        UnityEngine.Debug.Log(a�ama3.TrimEnd('-'));

        UnityEngine.Debug.Log("\n4. a�ama:");
        string a�ama4 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 4 == 0)
                a�ama4 += i + "-";
        }
        UnityEngine.Debug.Log(a�ama4.TrimEnd('-'));

        UnityEngine.Debug.Log("\n5. a�ama:");
        string a�ama5 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 5 == 0)
                a�ama5 += i + "-";
        }
        UnityEngine.Debug.Log(a�ama5.TrimEnd('-'));
    }



}
