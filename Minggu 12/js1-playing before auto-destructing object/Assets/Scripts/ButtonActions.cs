using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioDestructBehaviour audioDestructScriptedObject;
    public void PlaySound()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
    }
    public void DestroyAfterSoundStops()
    {
        audioDestructScriptedObject.enabled = true;
    }
}
