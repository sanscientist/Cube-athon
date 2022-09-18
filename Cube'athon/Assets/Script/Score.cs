using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //allows us to use UI elements - user interface

public class Score : MonoBehaviour
{
    //Reference Player - measure distance travelled to get points/score
    //create variable - public variableType variableName
    //Transform - type of variable that tells - position, rotation and scale
    public Transform player; //creates a player slot in script
    public Text score; //create score slot in script
  
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z); //tells the player's z position

        //assigns the player position to the text properties
        //must convert the position to a string type (convert from float to string)
        //"0" - displays the z position as a whole number not as decimals.
        score.text = player.position.z.ToString("0"); //displays position in text 
    }
}
