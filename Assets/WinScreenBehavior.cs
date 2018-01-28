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

    public AudioClip doorSound;
    public AudioClip transformationSound;
    public AudioClip plankSound;
    // Use this for initialization
    public AudioClip crashSound;
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
    void OnMouseOver()
    {
		Debug.Log("onmouseover win");
        if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(nextScene);
        }
    }
    public void goToNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void changeToWinMusic()
    {
        musicControl.clip = MusicaWin;
        audioControl.Play();
    }

    public void changeToZombiesMusic()
    {
        musicControl.clip = MusicaZombies;
        audioControl.Play();
    }

     public void playDoorSound()
    {
        audioControl.PlayOneShot(doorSound);
    }

    public void playTransformationSound()
    {
        audioControl.PlayOneShot(transformationSound);
    }

    public void playPlankSound()
    {
        audioControl.PlayOneShot(plankSound);
    }

    public void playCrashSound()
    {
        audioControl.PlayOneShot(crashSound);
    }
}
