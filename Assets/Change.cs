using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change  : MonoBehaviour
{
    public void SceneChangeCaseEgg()
    {
        SceneManager.LoadScene("Case;Egg");
    }

    public void SceneChangeCaseFlour()
    {
        SceneManager.LoadScene("Case;Flour");
    }

    public void SceneChangeCaseSoy()
    {
        SceneManager.LoadScene("Case;Soy");
    }

    ///COOKING///

    public void SceneChangeStart()
    {
        SceneManager.LoadScene("STEP1");
    }

    public void SceneChangeA()
    {
        SceneManager.LoadScene("STEP1~2");
    }

    public void SceneChangeB()
    {
        SceneManager.LoadScene("STEP1~~2");
    }

    public void SceneChangeC()
    {
        SceneManager.LoadScene("STEP2");
    }
    
    public void SceneChangeD()
    {
        SceneManager.LoadScene("STEP2~");
    }

    public void SceneChangeE()
    {
        SceneManager.LoadScene("STEP3");
    }

    public void SceneChangeF()
    {
        SceneManager.LoadScene("STEP3~");
    }

    public void SceneChangeG()
    {
        SceneManager.LoadScene("About_Tsukimiudon");
    }

    public void SceneChangeH()
    {
        SceneManager.LoadScene("About_Tsukuyomi");
    }

    public void SceneChangeI()
    {
        SceneManager.LoadScene("With_Tsukuyomi");
    }

    public void SceneChangeJ()
    {
        SceneManager.LoadScene("With_Tsukuyomi_End");
    }
    ///COOKING///

    
    ///MINIGAME///


    ////DON'T TOUCH BELOW///
    public void SceneChange()
    {
        SceneManager.LoadScene("S#1-2");
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("S#1-3");
    }

    public void SceneChange2()
    {
        SceneManager.LoadScene("S#2-1");
    }

    public void SceneChange3()
    {
        SceneManager.LoadScene("S#2-2");
    }

    public void SceneChange4()
    {
        SceneManager.LoadScene("S#3-1");
    }

    public void SceneChange5()
    {
        SceneManager.LoadScene("S#3-2");
    }

    public void SceneChange6()
    {
        SceneManager.LoadScene("S#4-1");
    }

    public void SceneChange7()
    {
        SceneManager.LoadScene("S#4-2");
    }

    public void SceneChange8()
    {
        SceneManager.LoadScene("S#4-3");
    }

    public void SceneChange9()
    {
        SceneManager.LoadScene("S#4-4");
    }

    public void SceneChange10()
    {
        SceneManager.LoadScene("S#4-5");
    }

    public void SceneChangeEnding()
    {
        SceneManager.LoadScene("TO_BE_CONTINUED");
    }

    public void SceneChangeRetryCooking()
    {
        SceneManager.LoadScene("STEP1");
    }
}