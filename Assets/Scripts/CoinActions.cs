using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//By Hamie Nouri - 24.09.2024

public class CoinActions : MonoBehaviour
{
    //=========>ROTATION<===========//
    // Adjust the speed of the rotation in degrees per second in the Inspector.
    public float rotationSpeed = 50f;

    //=========>MOVEMENT<===========//
    public float moveSpeed = 1.0f;  // Adjust the speed of the movement in the Inspector.
    public float amplitude = 1.0f;  // Adjust the height of the oscillation in the Inspector.
    private Vector3 startPos;       // Store the initial position of the object.


    void Start()
    {
        startPos = transform.position;  // Store the initial position of the object.
    }

    void Update()
    {
        MoveIt();
        ShakeIt();
    }

    //====================> Movement <====================/
    /*
     * <Title> MoveIt </Title>
     * Step 1: We want to calculate the vertical movement using Mathf.Sin to create an oscillation effect.
     * Step 2: Apply that calculation to a new position
     * Step 3: Define the new position as the current position of the object this script is attached to.
     */
    void MoveIt()
    {
        //Step 1
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * amplitude;  // Time.time is a value that increases over time, creating a smooth oscillation.

        //Step 2
        Vector3 newPosition = startPos + Vector3.up * verticalMovement;         // Apply the Calculation to a new empty position
        //Step 3
        transform.position = newPosition;                                       // Update the object's position by adding the vertical movement to its initial position.
    }

    //====================> ROTATE <========================/
    /*
     * <Title> ShakeIt </Title>
     * Step 1: Rotate the object around its axis continuously.
     */
    void ShakeIt()
    {
        //Step 1
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }

    //======================> Destroy <====================/
    /*
     * <TITLE>Destroy Object</TITLE>
     * Step 1: Detect collisions
     * Step 2: Check if the collision is Player
     * Step 3: If so, Find the Game Manager, 
     * Step 3.1: Make sure there is a game manager
     * Step 3.2: Add 1 to the |-> CollectedCoin <-| Game Manager Script
     * Step 4: Destroy Object this script is attached to
     */
    
    //Step 1
    void OnCollisionEnter(Collision collision)
    {
        //Step 2
        if (collision.gameObject.CompareTag("Player"))                  // Check if the collision is with the player.
        {
            //Step 3
            GameManager gameManager = FindObjectOfType<GameManager>();  // Find the GameManager script and call the AddCollectedCoin method.
            //Step 3.1
            if (gameManager != null)
            {
                //Step 3.2
                gameManager.AddCollectedCoin(1);                        // Increase CollectedCoin by 1.
            }
            //Step 4
            Destroy(gameObject);                                        // Destroy the object.
        }
    }
}
