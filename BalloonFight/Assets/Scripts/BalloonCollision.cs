﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCollision : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D col)
	{
		if(col.CompareTag("Player/Sword"))
		{
			Destroy(gameObject);
		}
	}
}
