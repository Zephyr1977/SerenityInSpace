using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDetails : MonoBehaviour
{
    [SerializeField] private float _minX, _maxX;

    [SerializeField] private GameObject[] _listDetails;
    [SerializeField] private GameObject[] _listShine;


    private void Start()
    {
        StartCoroutine(CreateDetails());
        StartCoroutine(CreateShine());
    }
    private IEnumerator CreateDetails()
    {
        while (true)
        {
            yield return new WaitForSeconds(6);
            Instantiate(_listDetails[Random.Range(0,_listDetails.Length)], new Vector2(Random.Range(_minX, _maxX), transform.position.y), Quaternion.Euler(0,0,Random.Range(0,270)));

        }
    }

    private IEnumerator CreateShine() 
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3,20));
            Instantiate(_listShine[Random.Range(0, _listShine.Length)], new Vector2(Random.Range(_minX, _maxX), transform.position.y), Quaternion.Euler(0, 0, Random.Range(0, 270)));

        }
    }
}
