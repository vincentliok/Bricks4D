using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Audio Manager Singleton that keeps track of sounds
// Call these functions to play sounds
// Credit for the sound goes to https://freesound.org/people/fordps3/sounds/186669/

public class AudioManagerScript : Singleton<AudioManagerScript>
{
    [SerializeField]
    private AudioSource boop;

    [SerializeField]
    private AudioSource beep;

    public void playboop()
    {
        boop.Play();
    }

    public void playbeep()
    {
        beep.Play();
    }
}
