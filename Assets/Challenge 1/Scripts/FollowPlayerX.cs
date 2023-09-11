/*
     * Darion Jeffries
     * FollowPlayerX
     * Challenge1
     * Fixed camera that follows player
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    // Update is called once per frame

    private Vector3 offset = new Vector3(20, 2, 7);
   
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
