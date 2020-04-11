using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_resolution : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start resolution setting");
        // Screen.SetResolution(1920, 1080, true);
        Screen.SetResolution(1920, 1080, FullScreenMode.ExclusiveFullScreen);
        Debug.Log("Resolution setting done");
        Debug.Log(Screen.currentResolution);
    }
}
