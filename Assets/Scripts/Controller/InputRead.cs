﻿using UnityEngine;
using System.Collections;

public class InputRead : MonoBehaviour {

	public GameObject playerRef;
	public GameObject currentController;

	void Awake()
	{
		//playerRef = GameObject.FindGameObjectWithTag("Player");
		currentController = GameObject.FindWithTag("PcController");
	}
	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {		
		if(currentController.GetComponent<PcController>().verifyJumpInput()){
			playerRef.GetComponent<PlayerControl>().jump();
		}
		
	}

	//void /// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	// /// </summary>
	void FixedUpdate()
	{
		float currentMoveSpeed = currentController.GetComponent<PcController>().getWalkInput();
		playerRef.GetComponent<PlayerControl>().move(currentMoveSpeed);
	}

	// void /// <summary>
	/// LateUpdate is called every frame, if the Behaviour is enabled.
	/// It is called after all Update functions have been called.
	// /// </summary>
	void LateUpdate()
	{
		if(currentController.GetComponent<PcController>().verifyAttkInput()){
			playerRef.GetComponent<PlayerControl>().attack();
		}	
	}
}
