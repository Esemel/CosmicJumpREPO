using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePlayerScript : MonoBehaviour
{
    Vector2 temp;
    float max = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (max <= 0.5)
        {
            temp = transform.localScale;

            temp.x += 0.001f;
            temp.y += 0.001f;
            transform.localScale = temp;
            max += 0.001f;
        }
        max += 0.001f;
        if (max >= 0.6)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = 270;  
            transform.rotation = Quaternion.Euler(rotationVector);
        }
    }

}
