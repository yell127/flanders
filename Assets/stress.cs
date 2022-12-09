using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class stress : MonoBehaviour
{
    public GameObject Kanji_minigame;

    public InputField input;
    public Button Enter;

    List<string> answer = new List<string> { "6" };

    public void ButtonClick()
    {
        if (answer.Contains(input.text))
        {
            SceneManager.LoadScene("STEP2~3");
        }
        else
        {
            SceneManager.LoadScene("STEP2~~3");
        }
    }
}