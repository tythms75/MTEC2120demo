using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class InteractableAudioClip : Interactable
{

    public AudioClip audio;

    public override void Start()
    {
        base.Start();

    }

    protected override void Interaction()
    {
        base.Interaction();

        Debug.Log("Audio file will be played now.");
        if (audio != null)

        {
            AudioManager.instance.PlayAudioAtPoint(audio, transform.position, 1f);
        }
    }
}
