using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
	public string name; //name of sound

	public AudioClip clip; //the audio clip

	[Range(0f, 1f)]
	public float volume;  //set an adjustable volume
	[Range(.1f, 3f)]
	public float pitch; //set an adjustable pitch

	public bool loop;  //option to loop

	[HideInInspector]
	public AudioSource source;

}
