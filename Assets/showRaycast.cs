using UnityEngine;
using System.Collections;

public class showRaycast : MonoBehaviour
{
	void Start(){
		RaycastHit hit;

	
	}
	
	void Update () {
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mouseWorldPosition.z = 0;
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
		Debug.DrawRay(transform.position, mouseWorldPosition  - transform.position, Color.green);

	}


}