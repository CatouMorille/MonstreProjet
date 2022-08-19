using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouvement : MonoBehaviour
{
    [SerializeField]
    Transform characterToFollow;
    [SerializeField]
    public Room room;
    [SerializeField]
    Camera camera;
    

    // Start is called before the first frame update
    void Start()
    {
        ChangeRoom ();
    }

    // Update is called once per frame
    void Update()
    {
        //Limites de la caméra
        float camHeight = camera.orthographicSize;
        float camWidth = camHeight * camera.aspect;
        float xGauche = room.transform.position.x - room.width / 2 + camWidth;
        float xDroite = room.transform.position.x + room.width / 2 - camWidth;
        float yHaut  = room.transform.position.y + room.height / 2 - camHeight;
        float yBas  = room.transform.position.y - room.height /2 + camHeight;
        
        float newX = transform.position.x;
        float newY = transform.position.y;

        //Empeche la camera d'aller au-dela d'un certain x
        if (characterToFollow.position.x > xGauche && 
            characterToFollow.position.x < xDroite)
        {
            newX = characterToFollow.position.x;
        }

        //Empeche la camera d'aller au-dela d'un certain y
        if (characterToFollow.position.y > yBas &&
            characterToFollow.position.y < yHaut)
        {
            newY = characterToFollow.position.y;
        }

        //Mouvement de la carmera
        transform.position = new Vector3(newX, newY, transform.position.z);

        /*
        Code possible, mais peu élégant (code kaméaméa)
        (imbriquer des if dans les accolades)
        (si elles ne sont pas dans des accolades, ce se rapproche d'un ou)
        
        if (characterToFollow.position.x > xGauche)
        {
            if (characterToFollow.position.x < xDroite)
            {
                if (characterToFollow.position.y > yBas)
                {
                    if (characterToFollow.position.y < yHaut)
                    {

                    }
                }
            }
        }

        Code plus élégant, avec des "et" = && (pour des ou mettre des ||)
        if (characterToFollow.position.x > xGauche && 
            characterToFollow.position.x < xDroite && 
            characterToFollow.position.y > yBas &&
            characterToFollow.position.y < yHaut)
        {
            
        }


        ou if (le personnage (characterToFollow) a une valeur plus grande que > xGauche)
        {
            la caméra se déplace
        }
        ou
        if (le personnage (characterToFollow) a une valeur plus petite < que xGauche)
        {
        STOP Il faut que la caméra s'arrête.
        }
        
        */
        
     
    }

    public void ChangeRoom ()
    {
        float x = room.transform.position.x;
        float y = room.transform.position.y;

        transform.position = new Vector3(x, y, transform.position.z);
    }

}

