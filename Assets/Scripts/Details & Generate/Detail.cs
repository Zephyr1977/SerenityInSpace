using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detail : MonoBehaviour
{
    private int _speed = 5;
    private float _lifeTime;

    private void Update()
    {
        _lifeTime += Time.deltaTime;
        if (_lifeTime > 30)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector2.up * (_speed* Time.deltaTime),Space.World);
        
    }
}
