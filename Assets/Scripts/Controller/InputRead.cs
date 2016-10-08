using UnityEngine;
using System.Collections;

public class InputRead : MonoBehaviour {

	private GameObject playerRef;


	void Awake()
	{
		playerRef = GameObject.FindGameObjectWithTag("Player");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//void /// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	// /// </summary>
	void FixedUpdate()
	{
		
	}

	// void /// <summary>
	/// LateUpdate is called every frame, if the Behaviour is enabled.
	/// It is called after all Update functions have been called.
	// /// </summary>
	void LateUpdate()
	{
		
	}
}
