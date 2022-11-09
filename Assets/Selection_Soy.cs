using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selection_Soy : MonoBehaviour
{
    
    public Text ChatText;
    public Text CharacterName;

    public string writerText = "";

    public GameObject d1;
    public GameObject d2;
    public GameObject d3;

    void Start3()
    {
      d1.SetActive(false);
      d2.SetActive(false);
      d3.SetActive(false);

      StartCoroutine(TextPractice2());  
    }


    public void D1()
    {
        SceneManager.LoadScene("Flour3");
    }

    public void D2()
    {
        SceneManager.LoadScene("Egg3");
    }

    public void D3()
    {
        SceneManager.LoadScene("Soy3");
    }
    

    IEnumerator NormalChat2(string narrator, string narration)
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

    IEnumerator TextPractice2()
    {
        string str = PlayerPrefs.GetString("Name");
        yield return StartCoroutine(NormalChat2("", ""));
        yield return StartCoroutine(NormalChat2("", ""));
        yield return StartCoroutine(NormalChat2("", ""));
        yield return StartCoroutine(NormalChat2("", ""));
        d1.SetActive(true);
        d2.SetActive(true);
        d3.SetActive(true);
    }

    
}
     
