using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrashAudio : MonoBehaviour
{
    public AudioSource crashAudio;

    void OnTriggerEnter(Collider collision)
    {
       crashAudio.Play();
    }
}
