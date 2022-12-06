using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float offsetBehind = -10;
    public float offsetAbove = 5;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        var offset = player.transform.forward * offsetBehind + Vector3.up * offsetAbove;
        transform.position = player.transform.position + offset;

        // Point the camera at the player
        var cameraForward = player.transform.position - transform.position;
        var cameraUp = Vector3.Cross(cameraForward.normalized, player.transform.right);
        transform.rotation = Quaternion.LookRotation(cameraForward, cameraUp);
    }
}
