using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Kanjigame_random : MonoBehaviour
{

    public List<string> GachaList = new List<string>() { "°¡·ç", "´ß", "¹Ð", "¹ç", "¾Ë" };
    public void Gacha()
    {
        int rand = Random.Range(0, GachaList.Count);

        if (GachaList[rand] == "°¡·ç")
        {
            SceneManager.LoadScene("kanjigame_powder");
        }
        if (GachaList[rand] == "´ß")
        {
            SceneManager.LoadScene("kanjigame_bird");
        }
        if (GachaList[rand] == "¹Ð")
        {
            SceneManager.LoadScene("kanjigame_wheat");
        }
        if (GachaList[rand] == "¹ç")
        {
            SceneManager.LoadScene("kanjigame_field");
        }
        if (GachaList[rand] == "¾Ë")
        {
            SceneManager.LoadScene("kanjigame_egg");
        }
    }

}
