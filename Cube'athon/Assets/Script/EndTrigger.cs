using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    //remember to tick 'isTriggered' in objects
     void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
