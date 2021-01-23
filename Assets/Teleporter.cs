using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject start;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "car")
        {
            other.transform.position = start.transform.position;
        }
    }

}
