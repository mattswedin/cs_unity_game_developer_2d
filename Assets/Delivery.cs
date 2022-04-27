using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasGemColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 notHasGemColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;
    bool hasGem;
    [SerializeField] float gemPickUpDelay = .5f;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // Debug.Log("Wtf Bra!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Gem" && !hasGem)
        {
            Debug.Log("Gem picked up!");
            hasGem = true;
            spriteRenderer.color = hasGemColor;
            Destroy(other.gameObject, gemPickUpDelay);
            
        }

        if (other.tag == "Chest" && hasGem)
        {
            Debug.Log("You Delivered my Gem!");
            hasGem = false;
            spriteRenderer.color = notHasGemColor;
        }

    }
}
