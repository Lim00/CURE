﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTextScript : MonoBehaviour
{
    public float destroyTime = 3f;

    void Start()
    {
        Destroy(gameObject, destroyTime); // After instantiated, removed after sometime
    }
}
