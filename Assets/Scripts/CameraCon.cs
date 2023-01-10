using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = .02f;
    public float rLerp = .01f;
    public Vector3 offset = new Vector3(0, 5, -10);

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position + offset, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
    }
}
