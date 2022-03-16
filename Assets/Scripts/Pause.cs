using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PanelPause;
    public GameObject PanelDead;

    private bool _isPause;

    public bool GetStatePause() 
    {
        return _isPause;
    }

    private void Start()
    {
        _isPause = false;
    }
    private void Update()
    {
        if (_isPause)
        {
            Time.timeScale = 0;
        }
        else if(!Camera.main.GetComponent<Improvements>().GetStateAcceleration())
        {
            Time.timeScale = 1;
        }
    }
    public void ActivePause(bool IsDead) 
    {

        _isPause = true;

        if (IsDead)
        {

            PanelDead.SetActive(true);
          
        }
        else 
        {
            PanelPause.SetActive(true);
        }
        
   
        
        

    }

    public void DeactivatePause() 
    {
        _isPause = false;
        PanelPause.SetActive(false);
    }
}
