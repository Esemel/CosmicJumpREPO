using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introscript : MonoBehaviour
{
    Vector2 temp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;

        temp.x += 0.001f;
        temp.y += 0.001f;
        transform.localScale = temp;
    }
}
