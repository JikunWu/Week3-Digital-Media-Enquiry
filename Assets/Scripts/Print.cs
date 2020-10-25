using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    //Task 2
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Balls")
        {
            print("You hit 1 ball.");
        }

    }
    void Start()
    {

    }

    void Update()
    {

    }
}
