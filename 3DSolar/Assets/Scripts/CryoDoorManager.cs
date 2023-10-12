using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryoDoorManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource introClip;

    [SerializeField]
    private Animator doorAnimator;

    [SerializeField]
    private GameObject topHalf;

    [SerializeField]
    private GameObject bottomHalf;

    public bool open = false;

    // Update is called once per frame
    void Update()
    {
        if (!open & !introClip.isPlaying)
        {
            open = true;
            doorAnimator.Play("door_2_open");
            StartCoroutine(InvisibleDoors());
        }
    }

    private IEnumerator InvisibleDoors()
    {
        yield return new WaitForSeconds(1);
        topHalf.SetActive(false);
        bottomHalf.SetActive(false);
    }
}
