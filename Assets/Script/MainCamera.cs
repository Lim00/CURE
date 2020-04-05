using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform MainCharacter;
    public Vector3 offset;
    private Transform CameraTransform;

    void Start()
    {
        CameraTransform = GetComponent<Transform>();

        offset.x = 2;
        offset.y = 0;
        offset.z = -4;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CameraTransform.position = new Vector3(MainCharacter.position.x + offset.x, MainCharacter.position.y, offset.z);
    }
}
