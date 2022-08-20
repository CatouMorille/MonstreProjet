using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageMirrorShow : MonoBehaviour
{
    [SerializeField] private GameObject customImage;

    private bool isShown;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && isShown)
        {
            HideImage();
        }
    }

    public void ShowImage()
    {
        customImage.SetActive(true);
        isShown = true;
    }

    public void HideImage()
    {
        customImage.SetActive(false);
        isShown = false;
    }

}
