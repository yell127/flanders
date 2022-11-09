using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selection_Flour : MonoBehaviour
{
    
    public Text ChatText;
    public Text CharacterName;

    public string writerText = "";

    public GameObject c1;
    public GameObject c2;
    public GameObject c3;

    void Start2()
    {
      c1.SetActive(false);
      c2.SetActive(false);
      c3.SetActive(false);

      StartCoroutine(TextPractice1());  
    }


    public void C1()
    {
        SceneManager.LoadScene("Flour2");
    }

    public void C2()
    {
        SceneManager.LoadScene("Egg2");
    }

    public void C3()
    {
        SceneManager.LoadScene("Soy2");
    }
    

    IEnumerator NormalChat1(string narrator, string narration)
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

    IEnumerator TextPractice1()
    {
        string str = PlayerPrefs.GetString("Name");
        yield return StartCoroutine(NormalChat1("", ""));
        yield return StartCoroutine(NormalChat1("", ""));
        yield return StartCoroutine(NormalChat1("", ""));
        yield return StartCoroutine(NormalChat1("", ""));
        c1.SetActive(true);
        c2.SetActive(true);
        c3.SetActive(true);
    }

    
}
     

