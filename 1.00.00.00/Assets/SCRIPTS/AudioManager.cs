using UnityEngine.Audio;
using System;
using UnityEngine;


public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;


    void Awake()
    {
        if (instance == null) //if there is no instance
            instance = this; //let this be the instance
		else
		{
            Destroy(gameObject);    //otherwise destroy this instance
            return;
		}

        DontDestroyOnLoad(gameObject); //dont destroy the game object when changing scenes

        foreach (Sound s in sounds)
		{
            s.source = gameObject.AddComponent<AudioSource>(); //add an audio source
            s.source.clip = s.clip;      //allows us to change the audio clip

            s.source.volume = s.volume; //alows us to edit the volume
            s.source.pitch = s.pitch; //allows us to edit the pitch
            s.source.loop = s.loop;
		}
    }

    void Start()
	{
        Play("MainTheme"); //play the main theme on start
	}



    public void Play (string name)
	{
        Sound s = Array.Find(sounds, sound => sound.name == name); //play the called sound by finding its name
        s.source.Play();

        if (s == null)
		{
            Debug.LogWarning("Sound " + name + " wasn't found. Check spelling!"); //in case of null reference, let me know
            return; //ignore the play method
		}
	}
}
