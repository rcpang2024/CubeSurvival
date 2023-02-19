using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float theForce = 0f; // var that applies the force
    public Joystick joystick;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (joystick.Vertical >= .1f)
        {
            rb.AddForce(0, 0, theForce * Time.deltaTime, ForceMode.VelocityChange);
        } 

        if (joystick.Vertical <= -.1f)
        {
            rb.AddForce(0, 0, -theForce * Time.deltaTime, ForceMode.VelocityChange);
        } 

        if (joystick.Horizontal >= .1f)
        {
            rb.AddForce(theForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 

        if (joystick.Horizontal <= -.1f)
        {
            rb.AddForce(-theForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        /*if (Input.GetKey("w")) // moves forward
        {
            rb.AddForce(0, 0, theForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s")) // moves backward
        {
            rb.AddForce(0, 0, -theForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) // moves to the left
        {
            rb.AddForce(-theForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d")) // moves to the right
        {
            rb.AddForce(theForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }*/

        if (rb.position.y < 1f)
        {
            FindObjectOfType<GameManager>().gameOver();
        }
    }
}
