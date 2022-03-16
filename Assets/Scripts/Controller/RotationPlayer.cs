using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlayer : MonoBehaviour
{
    private bool IsClockwise;
    private void Update()
    {
        if (IsClockwise)
        {
            transform.Rotate(0, 0, -1 * 7 * Time.deltaTime, Space.Self);
        }
        else 
        {
            transform.Rotate(0, 0, 7 * Time.deltaTime, Space.Self);
        }

    }

    public void SetRoute(bool value) 
    {
        IsClockwise = value;
    }
}
