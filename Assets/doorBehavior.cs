using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisableDoorCollision(){
		GetComponent<MeshCollider>().enabled = false;
	}

	public void EnableDoorCollision(){
		GetComponent<MeshCollider>().enabled = true;
	}
}
