using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Connect rigid bory component
    //  so we create a variable/object rb in order to connect it to the body 
    public Rigidbody rb;
    public float forwardForce = 800f;
    public float sidewaysForce = 600f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //When we are using a physics system is good to use FixedUpdate function
    //instead of simple updade function 
    void FixedUpdate()
    {
        //Add forward force:
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        //Add movement to the right
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0);
        }
        //add movement to the left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce *Time.deltaTime, 0, 0);
        }
    }
}
