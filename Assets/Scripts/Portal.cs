using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    Room room;

    public GameObject portal;
    private GameObject player;

    // Start is called before the first frame update
    // Set Player object by Tag assigned on sprite
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Trigger Teleport if collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
            CameraMouvement cameraMouvement = FindObjectOfType<CameraMouvement>();
            cameraMouvement.room = room;
        }
    }
}
