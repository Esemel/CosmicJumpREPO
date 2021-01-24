using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RocketFlyScript : MonoBehaviour
{
    Vector2 temp;
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.position;

        temp.x += 0.04f;
        temp.y += 0.02f;
        transform.position = temp;
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(8.0f);

        SceneManager.LoadScene("WinScene");

    }
}