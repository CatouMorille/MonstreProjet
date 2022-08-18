using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{

    // Variable that allows to pick up when set true
    private bool pickUpAllowed;

    [SerializeField] MirrorCount mirrorCount;
    

    // Allow press E to interact
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
            mirrorCount.IncreaseMirrorCount();
        }
    }

    // Enable Pick Up action if Player collides object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = true;
        }
    }

    // Disable Pick Up if Player does not collide object anymore
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = false;
        }
    }

    // Object disappears when "picked up"
    private void PickUp()
    {
        Destroy(gameObject);
    }
    
}
