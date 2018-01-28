using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movementSpecific : MonoBehaviour {
	public float force = 1;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		 if (Input.GetKeyDown (KeyCode.Space)){
			 GetComponent<Rigidbody>().AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
   		 }
	}

	public void Jump(){
		 GetComponent<Rigidbody>().AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
	}

	public void Death(){
		Debug.Log("plaf, muerto");
		//play death animation
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		//play game over music
		//show game over
	}
}
