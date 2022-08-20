using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{

    // Variable that allows to pick up when set true
    private bool pickUpAllowed;

    [SerializeField] MirrorCount mirrorCount;

    [SerializeField] ImageMirrorShow imageMirror1;
    [SerializeField] ImageMirrorShow imageMirror2;
    [SerializeField] ImageMirrorShow imageMirror3;

    public GameObject mirror1;
    public GameObject mirror2;
    public GameObject mirror3;




    // Allow press E to interact

    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
            mirrorCount.IncreaseMirrorCount();
            Destroy(gameObject);
        }
    }

    // Enable Pick Up action if Player collides object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpAllowed = true;
        }
    }

    // Disable Pick Up if Player does not collide object anymore
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpAllowed = false;
        }
    }

    // Object disappears when "picked up"
    private void PickUp()
    {
        if(mirrorCount.mirror == 0)
        {
            imageMirror1.ShowImage();
            Destroy(mirror1);
        }
        if (mirrorCount.mirror == 1)
        {
            imageMirror2.ShowImage();
            Destroy(mirror2);
        }
        if (mirrorCount.mirror == 2)
        {
            imageMirror3.ShowImage();
            Destroy(mirror3);
        }
    }
    
}
