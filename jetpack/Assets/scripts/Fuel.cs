using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour
{

    public Text score;
    public float number;
    public float numberPerSecond;
    public GameObject fuel;

    KillPlayer kp = new KillPlayer();

    void Start()
    {
        number = 100f;
        numberPerSecond = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = (int)number + " Fuel"+"%";

        if (kp.dead)
        {
            Debug.Log("hej");
        }
        else
        {
            number -= numberPerSecond * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fuel"))
        {
            number = 100f;
            Destroy(fuel);
        }
    }
}
