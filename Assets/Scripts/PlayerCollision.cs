using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //When we hit an object we need to disable players movement
    //so to do that we need to create a variable with the name of the Script that
    //we wawnt to disable.
    //Then inside UNITY we connect players movement box in the inspector with the movement
    //variable that we created. So we give a reference to the the movment of our player.
    public PlayerMovement movement;

    //Funcition that identifies collision between 2 objects
    //Unity identify it 
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
