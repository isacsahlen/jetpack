using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text score;
    public float number;
    public float numberPerSecond;

    void start()
    {
        number = 0f;
        numberPerSecond = 1f;
    }
    void Update()
    {
        score.text = (int)number + " Score";

        number += numberPerSecond * Time.deltaTime;

    }
    
}
