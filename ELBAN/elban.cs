﻿namespace ELBAN;

public class EBLO
{
    public static void BubbleSrt(IList<int> arr)
    {
        for (int i = 0; i < arr.Count - 1; i++)
        for (int j = 0; j < arr.Count - i - 1; j++)
            if (arr[j] > arr[j + 1])
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }
}
