using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
     private  float _minX,_maxX;
    [SerializeField]private GameObject[] _listObstacles;
    [SerializeField] private GameObject[] _listImprovements;

    

    private float _frequency=2;


    private void Start()
    {
        StartCoroutine(CreateObstacles());
        StartCoroutine(CreateCoins());
    }
    private IEnumerator CreateObstacles() 
    {
        while (true) 
        {
           
            yield return new WaitForSeconds(_frequency);
            Instantiate(_listObstacles[Random.Range(0,_listObstacles.Length)], new Vector2(Random.Range(_minX, _maxX), transform.position.y), Quaternion.identity);

        }
    }

    private IEnumerator CreateCoins() 
    {
       
            while (true)
            {

                yield return new WaitForSeconds(_frequency);
                Instantiate(_listImprovements[RandomImprovements()], new Vector2(Random.Range(_minX, _maxX), transform.position.y-5), Quaternion.identity);

            }
        
    }

    private int RandomImprovements() 
    {
        float rnd = Random.Range(0.0f, 1.01f);
        if (rnd < 0.10f)
        {
            return 1;
        }
        else if (rnd < 0.15f & rnd > 0.10f)
        {
            return 2;
        }
        else 
        {
            return 0;
        }
    }

    public void SetFrequncy(float valueTime) 
    {
        _frequency = 2 - valueTime;
    }
}
