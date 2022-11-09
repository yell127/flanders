using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selection_Egg : MonoBehaviour
{
    
    public Text ChatText;
    public Text CharacterName;

    public string writerText = "";

    public GameObject b1;
    public GameObject b2;
    public GameObject b3;

    void Start()
    {
      b1.SetActive(false);
      b2.SetActive(false);
      b3.SetActive(false);

      StartCoroutine(TextPractice());  
    }


    public void B1()
    {
        SceneManager.LoadScene("Flour");
    }

    public void B2()
    {
        SceneManager.LoadScene("Egg");
    }

    public void B3()
    {
        SceneManager.LoadScene("Soy");
    }
    

    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        CharacterName.text = narrator;
        writerText = "";

        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }

        while(true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextPractice()
    {
        string str = PlayerPrefs.GetString("Name");
        yield return StartCoroutine(NormalChat("", ""));
        yield return StartCoroutine(NormalChat("", ""));
        yield return StartCoroutine(NormalChat("", ""));
        yield return StartCoroutine(NormalChat("", ""));
        b1.SetActive(true);
        b2.SetActive(true);
        b3.SetActive(true);
    }

    
}
     

