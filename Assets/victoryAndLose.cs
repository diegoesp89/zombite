using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;
using UnityEngine.SceneManagement;


public class victoryAndLose : MonoBehaviour
{
    public int humanCount;
    public int humanDead;
    public GameObject victoryScreen;
    public GameObject victoryText;
    public int clicksAvailables;

    public GameObject tutorialText;

    public WinScreenBehavior audioRefence;
    public GameObject[] gameObjects;
    void OnGUI()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
    void Start()
    {

        FsmVariables.GlobalVariables.GetFsmInt("humans").Value = humanCount;
        FsmVariables.GlobalVariables.GetFsmGameObject("derecha").Value = GameObject.FindGameObjectsWithTag("Right")[0];
        FsmVariables.GlobalVariables.GetFsmGameObject("izquierda").Value = GameObject.FindGameObjectsWithTag("Left")[0];
        FsmVariables.GlobalVariables.GetFsmInt("clicksAvailable").Value = clicksAvailables;

    }

    // Update is called once per frame
    void Update()
    {
        if (FsmVariables.GlobalVariables.GetFsmInt("humans").Value == 0)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("CeilingTrap");

            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }
            Debug.Log("Ganaste");
            audioRefence.changeToWinMusic();
            victoryScreen.GetComponent<MeshRenderer>().enabled = true;
            victoryScreen.GetComponent<MeshCollider>().enabled = true;
            victoryText.GetComponent<MeshRenderer>().enabled = true;
            FsmVariables.GlobalVariables.GetFsmInt("humans").Value = -1;
            if (tutorialText)
            {
                tutorialText.GetComponent<MeshRenderer>().enabled = false;
            }
        }

    }

    public void Zombified()
    {
        humanCount--;
        FsmVariables.GlobalVariables.GetFsmInt("humans").Value--;
        Debug.Log("Zombificado");
    }

    public void Dead()
    {
        Debug.Log("Muerto");
    }

    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
