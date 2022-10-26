using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject canvas;
    public GameObject Player;
    public GameObject Fuel;
    public bool dead = false;
    // Start is called before the first frame update


    void Start()
    {
        canvas.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {


        if (dead == true)
        {
            Destroy(Player);
            canvas.SetActive(true);   
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("box"))
        {
            dead = true;
        }
    }
}
