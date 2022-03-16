using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private bool GetNumber(int x) 
    {
        if (x % 2 != 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
        
        
    }

    private void Print() 
    {
        for (int i = 0; i <= 100; i++) 
        {
            if (GetNumber(i)) 
            {
                Debug.Log(i);
            }
        }
    }

    private void Start()
    {
        Print();
    }
}
