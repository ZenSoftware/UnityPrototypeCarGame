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
        var offset = player.transform.forward * offsetBehind + Vector3.up * offsetAbove;
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}
