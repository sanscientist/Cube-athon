using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Reference the rigidbody compnent by calling it 'gravity'
    public Rigidbody gravity;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // Start is called before the first frame update
    //void Start() //initalise scene
    //{
        //Debug.Log("Hello World"); //Displays text in console
        //gravity.useGravity = false; //references the Rigidbody component features 'useGravity'
        //gravity.AddForce(0, 200, 500); //force on x,y,z
    //}

    // Update is called once per frame
    //unity preferes Fixed Update when dealing with physics 
    //can still use Update if needed too
    void FixedUpdate() //update every frame
    {
        //run a force constantly
        //Time.deltaTime - amount of seconds computer drew the last frame
        //Add forward force
        gravity.AddForce(0, 0, forwardForce * Time.deltaTime); //x,y,z forces 

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gravity.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gravity.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (gravity.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}
