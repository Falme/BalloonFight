using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Transform hand;
	
	[SerializeField]
	private float rotationVelocity;
	[SerializeField]
	private float movementationVelocity; 

	private bool left,right,up,down;

	void Update () {
		VerifyMovementation();
		VerifyRotation();
	}

	private void VerifyMovementation()
	{
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * movementationVelocity * Time.deltaTime);
		} else if(Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.right * movementationVelocity * Time.deltaTime);
		}

		
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.up * movementationVelocity * Time.deltaTime);
		} else if(Input.GetKey(KeyCode.S)){
			transform.Translate(Vector3.down * movementationVelocity * Time.deltaTime);
		}
	}

	private void VerifyRotation(){
		if(Input.GetKey(KeyCode.R))
		{
			hand.Rotate(Vector3.forward * rotationVelocity * Time.deltaTime);
		} else if(Input.GetKey(KeyCode.T)){
			hand.Rotate(-Vector3.forward * rotationVelocity * Time.deltaTime);
		}
	}

}
