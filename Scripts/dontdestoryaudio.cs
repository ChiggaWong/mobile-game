﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestoryaudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
