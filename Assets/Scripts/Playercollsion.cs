using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollsion : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisonInfo)
    {
        if (collisonInfo.collider.tag == "Obstacle")
        {
            //GetComponent<PlayerMovement>().enabled = false;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
