using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;

public class WordleDoorManager : MonoBehaviour
{
    [SerializeField]
    private Animator doorAnimator;

    [SerializeField]
    private GameObject topHalf;

    [SerializeField]
    private GameObject bottomHalf;

    [SerializeField]
    private Material baseMat;

    [SerializeField]
    private Material positionMat;

    [SerializeField]
    private Material correctMat;

    [SerializeField]
    private GameObject[] wordleScreens;

    [SerializeField]
    private TMP_Text[] wordleText;

    public int currentLetter = 5;

    public bool open = false;

    private string fjordCode = "FJORD";

    void Update()
    {
        string code = "";
        for (int i = 0; i < wordleText.Length; i++) 
        {
            code += wordleText[i].text;
        }

        if (code.Equals(fjordCode) && !open)
        {
            open = true;
            doorAnimator.Play("door_2_open");
            StartCoroutine(InvisibleDoors());
        }

        else if (currentLetter == 5)
        {
            char[] correctness = { 'n', 'n', 'n', 'n', 'n' };
            Dictionary<char, int> used = InitDictionary();
            for (int i = 0; i < wordleText.Length; i++)
            { 
                if (fjordCode[i] == code[i]) {
                    correctness[i] = 'c';
                    used[wordleText[i].text[0]] += 1;
                } 
            }

            for (int i = 0; i < wordleText.Length; i++)
            {
                if (fjordCode.Contains(wordleText[i].text) && used[wordleText[i].text[0]] == 0)
                {
                    correctness[i] = 'p';
                    used[wordleText[i].text[0]] += 1;
                }
            }

            for (int i = 0; i < wordleText.Length; i++) 
            {
                wordleText[i].text = "";

                if (correctness[i] == 'c')
                {
                    wordleScreens[i].GetComponent<Renderer>().material = correctMat;
                }

                else if (correctness[i] == 'p')
                {
                    wordleScreens[i].GetComponent<Renderer>().material = positionMat;
                }
            }
            currentLetter = 0;
        }
    }

    private IEnumerator InvisibleDoors()
    {
        yield return new WaitForSeconds(1);
        topHalf.SetActive(false);
        bottomHalf.SetActive(false);
    }

    public void addLetter(string letter)
    {
        wordleText[currentLetter].text += letter;
        wordleScreens[currentLetter].GetComponent<Renderer>().material = baseMat;
        currentLetter++;
    }

    private Dictionary<char, int> InitDictionary()
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        for (int i = 0; i < alphabet.Length; i++)
        {
            dict.Add(alphabet[i], 0);
        }
        return dict;
    }
}
