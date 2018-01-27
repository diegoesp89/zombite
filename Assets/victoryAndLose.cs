using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;
using UnityEngine.SceneManagement;


public class victoryAndLose : MonoBehaviour {
	public int humanCount;
	public int humanDead;

	// Use this for initialization
	void Start () {
		FsmVariables.GlobalVariables.GetFsmInt("humans").Value = humanCount;
		FsmVariables.GlobalVariables.GetFsmGameObject("derecha").Value = GameObject.FindGameObjectsWithTag("Right")[0];
		FsmVariables.GlobalVariables.GetFsmGameObject("izquierda").Value = GameObject.FindGameObjectsWithTag("Left")[0];
	}
	
	// Update is called once per frame
	void Update () {
		if(FsmVariables.GlobalVariables.GetFsmInt("humans").Value == 0){
			 Debug.Log("Ganaste");

		}
		
	}

	public void Zombified(){
		FsmVariables.GlobalVariables.GetFsmInt("humans").Value--;
		Debug.Log("Zombificado");
	}

	public void Dead(){
		Debug.Log("Muerto");
	}

	public void Restart(){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
