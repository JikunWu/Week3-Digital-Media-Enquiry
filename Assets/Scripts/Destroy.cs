using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //Task 3
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Balls")
        {
            Destroy(other.gameObject);
        }
    }
    void Start()
    {

    }
}