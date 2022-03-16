using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _backTranform;
    private float _backSize;
    private float _backPosition;
    void Start()
    {
        _backTranform = GetComponent<Transform>();
        _backSize = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {

        Move();
    }

    public void Move()
    {
        _backPosition += _speed * Time.deltaTime;
        _backPosition = Mathf.Repeat(_backPosition, _backSize+_backSize);
   
        _backTranform.position = new Vector3(0, _backPosition, 0);
    }
}