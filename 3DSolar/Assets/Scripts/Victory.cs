using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    [SerializeField]
    private Button mainMenu;

    void Start()
    {
        mainMenu.onClick.AddListener(() => SceneManager.LoadScene("Main Menu"));
    }
}
