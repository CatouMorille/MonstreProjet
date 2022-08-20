using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFootsteps : MonoBehaviour
{
    float inputHorizontal;
    float inputVertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
    
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            FindObjectOfType<AudioManager>().Play("footsteps");
            Debug.Log("ICI");
        }
        else
        {
            FindObjectOfType<AudioManager>().Stop("footsteps");
        }
    }
}
