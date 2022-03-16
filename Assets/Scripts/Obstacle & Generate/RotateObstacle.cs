using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    private int[] _listValue = new int[2] { -1, 1 };

    private int _rnd;
    private int _speed;
    private void Start()
    {
        _speed = Random.Range(2, 20);
        _rnd = _listValue[Random.Range(0, 2)];
    }
    private void Update()
    {
        transform.Rotate(0, 0,_rnd  * Time.deltaTime* _speed, Space.Self);
    }
}
