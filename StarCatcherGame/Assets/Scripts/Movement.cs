using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight; 

	public Transform groundPoint;
	public float radius;
	public LayerMask groundMask;
	public int extraJumps;
	int DefaultExtraJumps;

	bool isGrounded;


	public Rigidbody2D rb; 

	void Move () {
		Vector2 moveDir = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, rb.velocity.y);
		rb.velocity = moveDir;
	}

	void Jump () {
		CheckGrounded ();
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
			rb.AddForce(new Vector2 (0, jumpHeight));
		}
	}
	void DoubleJump (){
		if(Input.GetKeyDown(KeyCode.Space) && extraJumps >= 1 && !isGrounded){
			rb.AddForce(new Vector2 (0, jumpHeight));
			extraJumps -= 1; 
			}
		}
	void CheckGrounded () {
		isGrounded = Physics2D.OverlapCircle (groundPoint.position, radius, groundMask);
		if (isGrounded) {
			extraJumps = DefaultExtraJumps;
		}
	}

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		DefaultExtraJumps = extraJumps;
	}
		
	void Update (){
		Move ();
		Jump ();
		DoubleJump ();
	}

	void OnDrawGizmos () {
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(groundPoint.position, radius); 
	}
}
