using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBehavior : MonoBehaviour
{
    public AudioClip openingDoor, closingDoor;
    public AudioSource musicControl;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisableDoorCollision()
    {
        musicControl.clip = closingDoor;
        musicControl.Play();
        GetComponent<MeshCollider>().enabled = false;
    }

    public void EnableDoorCollision()
    {
        musicControl.clip = openingDoor;
        musicControl.Play();
        GetComponent<MeshCollider>().enabled = true;
    }
}
