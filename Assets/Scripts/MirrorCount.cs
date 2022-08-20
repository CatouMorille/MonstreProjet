using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MirrorCount : MonoBehaviour
{
    
    // Variable Count Collectible from 0
    public int mirror = 0;

    // Change text of counting
    [SerializeField] private TextMeshProUGUI mirrorText;

    // count mirror
    public void IncreaseMirrorCount()
    {
            mirror++;
            mirrorText.text = "Mirror Fragments: " + mirror + "/3";
    }
}
