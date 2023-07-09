using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_Sound : MonoBehaviour
{
    public AudioSource sound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
    }
}
