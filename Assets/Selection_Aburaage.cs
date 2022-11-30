using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selection_Aburaage : MonoBehaviour
{
    
    public Text ChatText;
    public Text CharacterName;

    public string writerText = "";

    public GameObject f1;
    public GameObject f2;
    public GameObject f3;

    void Start3()
    {
      f1.SetActive(false);
      f2.SetActive(false);
      f3.SetActive(false);

      StartCoroutine(TextPractice4());  
    }


    public void F1()
    {
        SceneManager.LoadScene("Aburaage_fail");
    }

    public void F2()
    {
        SceneManager.LoadScene("Aburaage_success");
    }

    public void F3()
    {
        SceneManager.LoadScene("Aburaage_fail");
    }
    

    IEnumerator NormalChat4(string narrator, string narration)
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

    IEnumerator TextPractice4()
    {
        string str = PlayerPrefs.GetString("Name");
        yield return StartCoroutine(NormalChat4("", ""));
        yield return StartCoroutine(NormalChat4("", ""));
        yield return StartCoroutine(NormalChat4("", ""));
        yield return StartCoroutine(NormalChat4("", ""));
        f1.SetActive(true);
        f2.SetActive(true);
        f3.SetActive(true);
    }

    
}
     
