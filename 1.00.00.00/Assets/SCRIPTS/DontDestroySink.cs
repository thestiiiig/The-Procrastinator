using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySink : MonoBehaviour
{

	void Awake()
	{
		DontDestroyOnLoad(transform.root.gameObject); //dont destroy the sink
	}
}
