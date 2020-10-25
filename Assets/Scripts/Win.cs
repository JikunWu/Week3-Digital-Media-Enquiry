using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    //Task 5
    public static GameObject txt;
    void Start()
    {
        txt = GameObject.Find("win");
        txt.SetActive(false);
    }


    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Desk")
        {
            txt.SetActive(true);
        }
    }
}
