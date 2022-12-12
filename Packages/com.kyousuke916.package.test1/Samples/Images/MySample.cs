using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySample : MonoBehaviour
{
    void Start()
    {
        MyFunc1 myFunc1 = new MyFunc1();
        myFunc1.SetValue(100);
        myFunc1.Execute();
    }
}
