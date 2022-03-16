using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int _speed = 5;
    private float _lifeTime;

    private void Update()
    {
        _lifeTime += Time.deltaTime ;
        if (_lifeTime > 30) 
        {
            Destroy(gameObject);
        }

        transform.Translate(0, _speed * Time.deltaTime, 0,Space.World);
    }
}
