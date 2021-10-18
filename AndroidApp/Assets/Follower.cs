using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset;
    
    void LateUpdate()
    {
        transform.position = Target.position  + offset; //adds two vectors and applies them to the camera position
    }
}
