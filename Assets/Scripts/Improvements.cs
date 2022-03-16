using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Improvements : MonoBehaviour
{
    private GameObject _player;
    private SpriteRenderer _spriteShield;

    private float _timeShield;
    private float _timeAcceleration;
    private bool _isStop;

    private bool _isActiveAcceleration;


    public bool GetStateAcceleration() 
    {
        return _isActiveAcceleration;
    }
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _spriteShield = GameObject.FindGameObjectWithTag("ShieldForPlayer").GetComponent<SpriteRenderer>();
  
    }
    private void Update()
    {
        CheckShield();
        CheckAcceleration();


    }

    private void CheckAcceleration() 
    {
        if (_timeAcceleration > 0& !Camera.main.GetComponent<Pause>().GetStatePause())
        {
            _isActiveAcceleration = true;
            _timeAcceleration -= Time.deltaTime;
            Time.timeScale = 1.5f;
        }
        else if(!Camera.main.GetComponent<Pause>().GetStatePause())
        {
            _isActiveAcceleration = false;
            Time.timeScale = 1;
        }
    }
    private void CheckShield() 
    {
        if (_timeShield > 4)
        {
            _spriteShield.color = new Color(1, 1, 1, 1);
            _player.tag = "Shield";
            _timeShield -= Time.deltaTime;
        }
        else if (_timeShield <= 4 & _timeShield > 0)
        {

            if (!_isStop)
            {
                StartCoroutine(HideShide());
            }

            _timeShield -= Time.deltaTime;
        }
        else if (_timeShield < 0 & _spriteShield.color.a<=0.1f)
        {
            _player.tag = "Player";
            _spriteShield.color = new Color(1, 1, 1, 0);
        }
    }

    IEnumerator HideShide() 
    {
        _isStop = true;
   

        while (_spriteShield.color.a > 0) 
        {
            Debug.Log(_spriteShield.color.a);
            _spriteShield.color = new Color(1, 1, 1, _spriteShield.color.a - 1* Time.deltaTime / 5);
            yield return null;
        }
        
        
    }

    public void SetTimeShield() 
    {
        _timeShield = 10;
        _isStop = false;
    }

    public void SetTimeAcceleration() 
    {
        _timeAcceleration = 20;
    }



}
