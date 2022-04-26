using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform playerBody;
    private Vector3 offset;
    //follows player using offset instead of childing the item
    private void Start()
    {
        offset = transform.position - playerBody.transform.position;
    }
    void LateUpdate()
    {
        transform.position = playerBody.transform.position + offset;
    }
}
