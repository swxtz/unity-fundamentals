using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// TODO: Futuro codigo

public class Speedometer : MonoBehaviour
{

    public Rigidbody car;

    public float maxSpeed = 0.0f;
    public float minSpeedPointerAngle;
    public float maxSpeedPointerAngle;

    public RectTransform pointerHolder;
    public TMPro.TMP_Text speedLabel;   

    void Update()
    {
        float speed = car.velocity.magnitude * 3.6f;

        speedLabel.text = (int)speed + "";
        speedLabel.alignment = TMPro.TextAlignmentOptions.Center;
        pointerHolder.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minSpeedPointerAngle, maxSpeedPointerAngle, speed / maxSpeed));
    }
}
