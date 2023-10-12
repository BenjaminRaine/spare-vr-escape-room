using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVictory : MonoBehaviour
{
    public void SwapScenes()
    {
        SceneManager.LoadScene("Victory");
    }
}
