using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneTrigger : MonoBehaviour
{
    [SerializeField]
    MirrorCount mirrorCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (mirrorCount.mirror == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
