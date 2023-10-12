using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Button mainMenu;

    [SerializeField]
    private Light engineLight;

    [SerializeField]
    private AudioSource shutdownSound;

    void Start()
    {
        mainMenu.onClick.AddListener(() => SceneManager.LoadScene("Main Menu"));
        StartCoroutine(TurnOffEngine());
    }

    IEnumerator TurnOffEngine()
    {
        yield return new WaitForSeconds(2);
        shutdownSound.Play();
        if (engineLight.intensity > 0)
        {
            engineLight.intensity -= Time.deltaTime * 1300;
        }
    }
}
