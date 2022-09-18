using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] Vector3 offSet;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offSet;
    }
}
