﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public int lifetime;
    void Start() {
        lifetime = 2;
    }

    // Update is called once per frame
    void Update() {
        if(gameObject.name == "Bullet(Clone)") {
            Destroy (gameObject, lifetime);
        }
    }
}
