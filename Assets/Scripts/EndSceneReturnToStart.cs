using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneReturnToStart : MonoBehaviour
{
    public int sceneID;

    public void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}

