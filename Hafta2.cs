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
        UnityEngine.Debug.Log("1. aþama:");
        string aþama1 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            aþama1 += i + "-";
        }
        UnityEngine.Debug.Log(aþama1.TrimEnd('-'));

        UnityEngine.Debug.Log("\n2. aþama:");
        string aþama2 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 2 == 0)
                aþama2 += i + "-";
        }
        UnityEngine.Debug.Log(aþama2.TrimEnd('-'));

        UnityEngine.Debug.Log("\n3. aþama:");
        string aþama3 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 3 == 0)
                aþama3 += i + "-";
        }
        UnityEngine.Debug.Log(aþama3.TrimEnd('-'));

        UnityEngine.Debug.Log("\n4. aþama:");
        string aþama4 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 4 == 0)
                aþama4 += i + "-";
        }
        UnityEngine.Debug.Log(aþama4.TrimEnd('-'));

        UnityEngine.Debug.Log("\n5. aþama:");
        string aþama5 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 5 == 0)
                aþama5 += i + "-";
        }
        UnityEngine.Debug.Log(aþama5.TrimEnd('-'));
    }



}
