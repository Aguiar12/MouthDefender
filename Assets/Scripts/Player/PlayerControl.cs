using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public bool facingRight = true;
    public bool jump = false;

    public float moveForce = 250f;
    public float maxSpeed = 2f;
    public float jumpForce = 0.0000000005f;

    //private Transform groundCheck;
    //private bool grounded = false;
    private Animator anim;

    void Awake()
    {
        //groundCheck = transform.Find("groundCheck");
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if(Input.GetButtonDown("Jump"))
            jump = true;
    }

    void FixedUpdate() 
    {
        float h = Input.GetAxis("Horizontal");

        anim.SetFloat("Velocidade", Mathf.Abs(h));

        if(h * GetComponent<Rigidbody2D>().velocity.x < maxSpeed)
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * h * moveForce);

		if(Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed)
			GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if(h > 0 && !facingRight)
			Flip();
		else if(h < 0 && facingRight)
			Flip();

		if(jump)
		{
			anim.SetTrigger("Pulo");

			//int i = Random.Range(0, jumpClips.Length);
			//AudioSource.PlayClipAtPoint(jumpClips[i], transform.position);

			GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce * 0.3f));

			jump = false;
		}
	}
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
        
}