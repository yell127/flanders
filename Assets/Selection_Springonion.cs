using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selection_Springonion : MonoBehaviour
{
    
    public Text ChatText;
    public Text CharacterName;

    public string writerText = "";

    public GameObject e1;
    public GameObject e2;
    public GameObject e3;

    void Start3()
    {
      e1.SetActive(false);
      e2.SetActive(false);
      e3.SetActive(false);

      StartCoroutine(TextPractice3());  
    }


    public void E1()
    {
        SceneManager.LoadScene("Springonion_success");
    }

    public void E2()
    {
        SceneManager.LoadScene("Springionion_fail");
    }

    public void E3()
    {
        SceneManager.LoadScene("Springionion_fail");
    }
    

    IEnumerator NormalChat3(string narrator, string narration)
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

    IEnumerator TextPractice3()
    {
        string str = PlayerPrefs.GetString("Name");
        yield return StartCoroutine(NormalChat3("", ""));
        yield return StartCoroutine(NormalChat3("", ""));
        yield return StartCoroutine(NormalChat3("", ""));
        yield return StartCoroutine(NormalChat3("", ""));
        e1.SetActive(true);
        e2.SetActive(true);
        e3.SetActive(true);
    }

    
}
     
