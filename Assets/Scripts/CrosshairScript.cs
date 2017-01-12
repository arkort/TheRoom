using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour
{
    public Texture crosshairTexture;
    Rect rectangle;

    // Use this for initialization
    void Start()
    {
        var crosshairSize = Screen.width * 0.02f;
        rectangle = new Rect(
            Screen.width / 2f - crosshairSize / 2,
            Screen.height / 2f - crosshairSize / 2,
            crosshairSize,
            crosshairSize);
    }

    void OnGUI()
    {
        GUI.DrawTexture(rectangle, crosshairTexture);
    }
}
