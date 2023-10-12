using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockpitDoorManager : MonoBehaviour
{

    [SerializeField]
    private Animator doorAnimator;

    [SerializeField]
    private GameObject topHalf;

    [SerializeField]
    private GameObject bottomHalf;

    [SerializeField]
    private AudioSource dialog;

    public bool open = false;

    private bool[] inPlace = { false, false, false, false, false, false, false, false };

    // Update is called once per frame
    void Update()
    {
        bool totalPlacement = true;
        for (int i = 0; i < inPlace.Length; i++)
        {
            totalPlacement &= inPlace[i];
        }

        if (totalPlacement && !open)
        {
            open = true;
            dialog.Play();
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

    public void planetPlaced(int index)
    {
        inPlace[index] = true;
    }

    public void planetRemoved(int index)
    {
        inPlace[index] = false;
    }
}
