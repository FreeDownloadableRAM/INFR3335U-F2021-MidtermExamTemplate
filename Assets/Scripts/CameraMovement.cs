using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject JohnLemon; //Get the player

    private Vector3 offset; //Follow the player


    // Start is called before the first frame update
    void Start()
    {
        //Calculate where the player is
        offset = transform.position - JohnLemon.transform.position;
    }

    // Late Update is called to update once per frame after Update()
    void LateUpdate()
    {
        //Set camera position to the player
        transform.position = JohnLemon.transform.position + offset;
    }
}
