using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions 
{
    public static void GetRandomSubset<T>(this List<T> list, int count, List<T> result)
    {
        if (count > list.Count)
            count = list.Count;

        result.Clear();
        int n = list.Count;

        for (int i = 0; i < count; i++)
        {
            int j = UnityEngine.Random.Range(i, n);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;

            result.Add(list[i]);
        }
    }
}
