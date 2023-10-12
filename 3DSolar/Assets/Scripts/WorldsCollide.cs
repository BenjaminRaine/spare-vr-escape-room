using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WorldsCollide : MonoBehaviour
{
    [SerializeField]
    private int planetNum;

    //public Unity Events we can use in the editor and tie other functions to.
    public UnityEvent onEnter, onExit;

    //Checks if the current collider entering is the Button and sets off OnPressed event.
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mercury" && planetNum == 0 ||
            other.tag == "Venus" && planetNum == 1 ||
            other.tag == "Earth" && planetNum == 2 ||
            other.tag == "Mars" && planetNum == 3 ||
            other.tag == "Jupiter" && planetNum == 4 || 
            other.tag == "Saturn" && planetNum == 5 || 
            other.tag == "Uranus" && planetNum == 6 ||
            other.tag == "Neptune" && planetNum == 7)
        {
            onEnter?.Invoke();
        }
    }

    //Checks if the current collider exiting is the Button and sets off OnReleased event.
    //It will also call a Coroutine to make the button inactive for however long deadTime is set to.
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Mercury" && planetNum == 0 ||
            other.tag == "Venus" && planetNum == 1 ||
            other.tag == "Earth" && planetNum == 2 ||
            other.tag == "Mars" && planetNum == 3 ||
            other.tag == "Jupiter" && planetNum == 4 ||
            other.tag == "Saturn" && planetNum == 5 ||
            other.tag == "Uranus" && planetNum == 6 ||
            other.tag == "Neptune" && planetNum == 7)
        {
            onExit?.Invoke();
        }
    }
}
