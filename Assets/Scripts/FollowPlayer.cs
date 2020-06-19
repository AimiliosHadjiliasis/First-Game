
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Transform: get a link to our player about its possition, rotation and scale
    public Transform player;

    //  Vector3 variable that holds the possition of our camera
    //  This creates an offset for the possition of the camera inside unity
    //  so we change the values there to reposition the camera
    public Vector3 offset; 

    // Update is called once per frame
    void Update()
    {
        //When we write "transform" with non capital letters, it refers to the transform
        //of our current object.
        //Here we set the possition of the camera to the player possition
        //and we also add the offset the we set in Unity so we efficiently reposition
        //the camera and "attach it" to the player
        transform.position = player.position + offset;
    }
}
