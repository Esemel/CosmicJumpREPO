using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour
{
    public int Score = 2;
    public Text ScoreText;
    void Start()
    {
        
       

        // Update is called once per frame
        void Update()
        {
            Score += 1;
            ScoreText.text = Score.ToString();
        }
    }
}
