using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger2 : MonoBehaviour
{
    public Dialogue info;

    public void Trigger2()
    {
        var system = FindObjectOfType<DialogueSystem2>();
        system.Begin(info);
    }
}