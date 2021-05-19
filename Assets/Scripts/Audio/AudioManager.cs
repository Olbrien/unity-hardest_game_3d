using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    float lenghtOfSong;

    private static AudioManager audioManagerInstance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (audioManagerInstance == null) { audioManagerInstance = this; }
        else { Destroy(gameObject); }    

        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;

            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;

            sound.source.loop = sound.loop;
        }

        PlayMusic("SongOne");
    }

    public void PlayMusic(string name)
    {
        Sound a = Array.Find(sounds, sound => sound.name == name);

        a.source.Play();
    }

    public void PlaySound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.PlayOneShot(s.clip);
    }


    public void StopMusic(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }


    public void MusicVolumeOn()
    {
        foreach (var sound in sounds)
        {
            if (sound.loop == true)
            {
                sound.source.volume = 1;
            }
        }
    }

    public void MusicVolumeOff()
    {
        foreach (var sound in sounds)
        {
            if (sound.loop == true)
            {
                sound.source.volume = 0;
            }
        }
    }

    public void SoundVolumeOn()
    {
        foreach (var sound in sounds)
        {
            if (sound.loop == false)
            {
                sound.source.volume = 1;
            }
        }
    }

    public void SoundVolumeOff()
    {
        foreach (var sound in sounds)
        {
            if (sound.loop == false)
            {
                sound.source.volume = 0;
            }
        }
    }
}
