using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorManaher : MonoBehaviour
{
    [SerializeField]
    private Animator doorAnimator;

    // Start is called before the first frame update
    void Start()
    {
        doorAnimator.Play("glass_door_open");
    }
}
