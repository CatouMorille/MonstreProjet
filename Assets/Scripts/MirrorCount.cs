using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MirrorCount : MonoBehaviour
{
    
    // Variable Count Collectible from 0
    private int mirror = 0;

    // Change text of counting
    [SerializeField] private Text mirrorText;

    // count mirror
    public void IncreaseMirrorCount()
    {
            mirror++;
            mirrorText.text = "Mirror: " + mirror + "/3";
    }
}