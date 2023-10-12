using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Button start;

    [SerializeField]
    private Button exit;

    void Start()
    {
        start.onClick.AddListener(() => SceneManager.LoadScene("Bridge"));
        exit.onClick.AddListener(() => Application.Quit());
    }
}
