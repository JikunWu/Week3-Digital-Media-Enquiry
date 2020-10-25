using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInstantiate : MonoBehaviour
{
    //Task 4
    public GameObject balls;
    float range = 3f;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Balls")
        {
            Instantiate (balls,new Vector3(Random.Range(-range, 0), 0, 0),Quaternion.identity);
            Instantiate (balls, new Vector3(Random.Range(range, 0), 0, 0), Quaternion.identity);
        }
    }

    void Start()
    {  
    }


    void Update()
    {

    }

}
