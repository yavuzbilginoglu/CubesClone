using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxrotate : MonoBehaviour
{
    public int speed;
    Skybox skybox;

    void FixedUpdate()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 120);
    }
}
