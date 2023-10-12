using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

public class HiddenInk : MonoBehaviour
{

    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "InkLight")
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "InkLight")
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}   