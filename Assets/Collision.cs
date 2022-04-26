using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log("Wtf Bra!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Twinkle Twinkle");
    }
}
