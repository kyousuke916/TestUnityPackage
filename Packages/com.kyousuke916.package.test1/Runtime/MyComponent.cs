using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public int Value;
    
    void Start()
    {
        Debug.Log($"MyComponent Value:{Value}");
    }
}
