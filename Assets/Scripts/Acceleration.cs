using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Camera.main.GetComponent<Improvements>().SetTimeAcceleration();
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        foreach (Transform child in transform) 
        {
            child.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
