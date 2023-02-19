using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collision) // function runs when player hits another object
    {
        if (collision.collider.tag == "Enemy") // checks if the player has hit an object w/ "enemy" tag
        {
            movement.enabled = false; // disables player movement
            FindObjectOfType<GameManager>().gameOver();
        }
    }
}
