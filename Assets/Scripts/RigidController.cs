using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidController : MonoBehaviour
{
	public float moveSpeed;
	public Rigidbody pigPhysics;
	public float jumpForce;
	public float forwardForce = 2000f;

	// Start is called before the first frame update
	void Start()
	{
		pigPhysics = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		pigPhysics.AddForce(0, 0, forwardForce * Time.deltaTime);

		pigPhysics.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, pigPhysics.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

		if(Input.GetButtonDown("Jump"))
            
		{
			pigPhysics.velocity = new Vector3(pigPhysics.velocity.x, jumpForce, pigPhysics.velocity.z);
		}
	}
}
