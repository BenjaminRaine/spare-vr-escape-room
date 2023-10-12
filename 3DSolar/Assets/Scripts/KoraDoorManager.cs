using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KoraDoorManager : MonoBehaviour
{
    [SerializeField]
    private Animator doorAnimator;

    [SerializeField]
    private TMP_Text code;

    
    public bool open = false;

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log(code.text);
        if (code.text.Equals("343") && !open)
        {
            open = true;
            doorAnimator.Play("glass_door_open");
        }

        else if (code.text.Length >= 3)
        {
            code.text = "";
        }
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
