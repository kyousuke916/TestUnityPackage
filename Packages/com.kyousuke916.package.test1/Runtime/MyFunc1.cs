using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFunc1
{
    public int Value = 0;

    public void SetValue(int value)
    {
        Value = value;
    }

    public void Execute()
    {
        Debug.Log($"MyFunc1.Execute Value:{Value}");
    }
}
