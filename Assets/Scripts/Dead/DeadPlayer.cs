using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            PlayerPrefs.SetInt("Dead", PlayerPrefs.GetInt("Dead")+1);
            Camera.main.GetComponent<Pause>().ActivePause(true);
            
        }
    }
}
