using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Public variables, visible in Unity inspector
    public float forceStrength;
    
    // These will be called by each button for movement
    public void MoveUp()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.up * forceStrength);
    }
    public void MoveLeft()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.left * forceStrength);
    }
    public void MoveRight()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.right * forceStrength);
    }
    public void MoveDown()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.down * forceStrength);
    }
}
