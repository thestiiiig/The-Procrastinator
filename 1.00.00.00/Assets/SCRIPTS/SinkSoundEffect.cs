using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkSoundEffect : MonoBehaviour
{
	public AudioSource audioSource; //get audio source component

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" && !audioSource.isPlaying) //if the player is in the zone
		{
			audioSource.Play();
			Debug.Log("Sink sound is playing");         //play the sink sound effect
		}
	}
}
