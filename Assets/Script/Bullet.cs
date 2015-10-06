﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	//Speed
	public float speed = 10;

	//Target
	public Transform target;

	void FixedUpdate(){

		if (target) {
			//Fly towards the target
			Vector3 dir = target.position - transform.position;
			//Rigidbody.velocity = dir.normalized * speed;

		} else {
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter(Collider co) {
		Health health = co.GetComponentInChildren<Health> ();
		if (health) {
			health.decrease ();
			Destroy (gameObject);
		}
	}
}