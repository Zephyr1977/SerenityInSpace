using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{
    private int _speed = 7;
    private float _lifeTime;

    private void Update()
    {
        _lifeTime += Time.deltaTime;
        if (_lifeTime >8)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector2.left * (_speed * Time.deltaTime));

    }
}
