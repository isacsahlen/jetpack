using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text score;
    public float number;
    public float numberPerSecond;

    KillPlayer kp = new KillPlayer();

    void start()
    {
        number = 0f;
        numberPerSecond = 1f;
    }
    void Update()
    {
        score.text = (int)number + " Score";
        
        if(kp.dead == true)
        {
            
            Debug.Log("hej");
        }
        else
        {
            number += numberPerSecond * Time.deltaTime;
        }
            

    }
    
}
