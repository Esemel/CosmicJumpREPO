﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygenscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") //Change tag
            Destroy(gameObject);
    }
}

