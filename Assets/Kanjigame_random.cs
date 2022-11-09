using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Kanjigame_random : MonoBehaviour
{

    public List<string> GachaList = new List<string>() { "����", "��", "��", "��", "��" };
    public void Gacha()
    {
        int rand = Random.Range(0, GachaList.Count);

        if (GachaList[rand] == "����")
        {
            SceneManager.LoadScene("kanjigame_powder");
        }
        if (GachaList[rand] == "��")
        {
            SceneManager.LoadScene("kanjigame_bird");
        }
        if (GachaList[rand] == "��")
        {
            SceneManager.LoadScene("kanjigame_wheat");
        }
        if (GachaList[rand] == "��")
        {
            SceneManager.LoadScene("kanjigame_field");
        }
        if (GachaList[rand] == "��")
        {
            SceneManager.LoadScene("kanjigame_egg");
        }
    }

}
