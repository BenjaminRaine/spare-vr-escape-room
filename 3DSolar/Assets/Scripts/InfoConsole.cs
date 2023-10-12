using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoConsole : MonoBehaviour
{
    public int currentInfo = 0;

    [SerializeField]
    private GameObject[] info;

    // Start is called before the first frame update
    void Start()
    {
        info[0].SetActive(true);
    }

    public void SwitchInfo()
    {
        info[currentInfo].SetActive(false);
        currentInfo = (currentInfo + 1) % info.Length;
        info[currentInfo].SetActive(true);
    }
}
