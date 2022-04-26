using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // camera should be the same position as the player
    
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -2);
    }
}
