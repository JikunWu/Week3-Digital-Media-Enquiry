using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_balls : MonoBehaviour
{
    //Task 1

    public GameObject myObstacePrefab;

    float range = 5f;

    public float obstacleNumber;

    void Start()
    {
        GameObject whatever;

        int counter = 0;

        while (counter < obstacleNumber - 1)
        {
            whatever = Instantiate(myObstacePrefab);
            whatever.transform.position = new Vector3(Random.Range(-range, range), Random.Range(0, range), Random.Range(-range, range));
            counter++;
        }
    }

    void Update()
    {

    }
}

