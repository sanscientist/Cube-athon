using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //creates a reference to playermovement script - variable
    public PlayerMovement movement;
    //information on the obstacle we hit
    void OnCollisionEnter(Collision collisionInfo) //collisionInfo - reference name
    {
        //Displays the name of what we hit
        //Debug.Log(collisionInfo.collider.name);

        //checks object's tag
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit an obstacle");
            //stop player movement when hit the obstacle
            movement.enabled = false;

            //Search the GameManager Script
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
