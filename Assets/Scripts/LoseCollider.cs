using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
	// testing push from laptop
	private LevelManager levelManager;


	void OnTriggerEnter2D(Collider2D trigger)
	{
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        print ("Trigger");
		levelManager.LoadLevel("Lose");
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		print ("Collision");
	}


}
