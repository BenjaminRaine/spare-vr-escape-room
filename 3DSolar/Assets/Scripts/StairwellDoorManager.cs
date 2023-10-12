using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StairwellDoorManager : MonoBehaviour
{
    [SerializeField]
    private Animator doorAnimator;

    [SerializeField]
    private TMP_Text code;

    [SerializeField]
    private GameObject topHalf;

    [SerializeField]
    private GameObject bottomHalf;

    [SerializeField]
    private AudioSource dialog;

    public bool open = false;

    // Update is called once per frame
    void Update()
    {
        if (code.text.Equals("940") && !open)
        {
            open = true;
            doorAnimator.Play("door_2_open");
            dialog.Play();
            StartCoroutine(InvisibleDoors());
        }

        else if (code.text.Length >= 3)
        {
            code.text = "";
        }
    }

    private IEnumerator InvisibleDoors()
    {
        yield return new WaitForSeconds(1);
        topHalf.SetActive(false);
        bottomHalf.SetActive(false);
    }

    public void add0()
    {
        code.text += "0";
    }

    public void add1()
    {
        code.text += "1";
    }

    public void add2()
    {
        code.text += "2";
    }

    public void add3()
    {
        code.text += "3";
    }

    public void add4()
    {
        code.text += "4";
    }

    public void add5()
    {
        code.text += "5";
    }

    public void add6()
    {
        code.text += "6";
    }

    public void add7()
    {
        code.text += "7";
    }

    public void add8()
    {
        code.text += "8";
    }

    public void add9()
    {
        code.text += "9";
    }
}
