using UnityEngine;
using System.Collections;
using System;

public class PcController : MonoBehaviour, IControllerInterface {

	private float walkingSpeed;

	private bool isJumping;

	private bool isAttacking;

	private bool isUsingPowerUp;


    public bool verifyAttkInput()
    {
        return isAttacking;
    }

    public bool verifyJumpInput()
    {
        return isJumping;
    }

    public bool verifyPowerUpInput()
    {
        return isUsingPowerUp;
    }

    public float getWalkInput()
    {
        return walkingSpeed;
    }

    // Use this for initialization
    void Start () {
		walkingSpeed = 0f;
		isAttacking = false;
		isJumping = false;
		isUsingPowerUp = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		walkingSpeed = Input.GetAxis("Horizontal");        	
	}
}
