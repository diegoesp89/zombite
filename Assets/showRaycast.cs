using UnityEngine;
using System.Collections;

public class showRaycast : MonoBehaviour
{
	void Start(){
	
	}
	
	void Update () {
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mouseWorldPosition.z = 0;
		Debug.DrawRay(transform.position, mouseWorldPosition  - transform.position, Color.green);

	}


}