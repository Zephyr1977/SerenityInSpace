using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Camera.main.GetComponent<Improvements>().SetTimeShield();
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        
    }

   

}
