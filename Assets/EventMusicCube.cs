using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMusicCube : MonoBehaviour
{
	public AudioClip eventClip;
	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			AudioManager.manager.eventMusic.clip = eventClip;
			AudioManager.manager.StartCoroutine("PlayEventMusic");
		}
	}
}
