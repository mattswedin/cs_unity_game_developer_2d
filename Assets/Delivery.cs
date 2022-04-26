using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasGemColor
    bool hasGem;
    [SerializeField] float gemPickUpDelay = .5f;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log("Wtf Bra!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Gem" && !hasGem){
            Debug.Log("Gem picked up!");
            hasGem = true;
            Destroy(other.gameObject, gemPickUpDelay);
        }

        if (other.tag == "Chest" && hasGem){
            Debug.Log("You Delivered my Gem!");
            hasGem = false;
        }
    }
}
