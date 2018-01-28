using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HutongGames.PlayMaker;

public class WinScreenBehavior : MonoBehaviour
{
AudioSource audioControl;
	public string nextScene;
	public AudioSource musicControl;
	public AudioClip MusicaInicio;
	public AudioClip MusicaZombies;
	public AudioClip MusicaWin;
    // Use this for initialization
    void Start()
    {
		FsmVariables.GlobalVariables.GetFsmGameObject("audioControl").Value = GameObject.FindGameObjectsWithTag("Audio")[0];
		audioControl = GetComponent<AudioSource>();
		musicControl.clip = MusicaInicio;
		musicControl.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goToNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

	public void changeToWinMusic(){
		musicControl.clip = MusicaWin;
        audioControl.Play();
	}

	public void changeToZombiesMusic(){
		musicControl.clip = MusicaZombies;
        audioControl.Play();
	}
}
