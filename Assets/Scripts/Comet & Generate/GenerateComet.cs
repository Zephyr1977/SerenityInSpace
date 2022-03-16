using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateComet : MonoBehaviour
{
    [SerializeField] private float _minX, _maxX;

    [SerializeField] private GameObject[] _listObstacles;


    private void Start()
    {
        StartCoroutine(CreateComets());
    }
    private IEnumerator CreateComets()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5,30));
            Instantiate(_listObstacles[Random.Range(0,_listObstacles.Length)], new Vector2( 10.8f, Random.Range(_minX, _maxX)), Quaternion.Euler(0,0,42));

        }
    }
}
