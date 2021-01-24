using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerOxygen : MonoBehaviour
{

    
    public Slider mSlider;
    // Start is called before the first frame update
    void Start()
    {
        mSlider.value = 100.0f;
        mSlider.minValue = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        mSlider.value -= 0.005f;
        if (mSlider.value == 0.0f)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Oxygen") 
            mSlider.value = 100.0f;
    }
}
