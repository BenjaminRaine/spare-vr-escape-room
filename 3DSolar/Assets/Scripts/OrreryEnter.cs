using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrreryEnter : MonoBehaviour
{
    [SerializeField]
    private AudioSource dialog;

    private bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !played)
        {
            played = true;
            dialog.Play();
        }
    }
}
