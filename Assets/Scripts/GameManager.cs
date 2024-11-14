using UnityEngine;
using UnityEngine.SceneManagement; //<<<<< Added Lib
/* Hamie Nouri | 24.09.2024 */

public class GameManager : MonoBehaviour
{
    //=========> Declaration <===========//
    private int CollectedCoin = 0;
    private bool isPaused = false;

    //=========> Coin Collected <========//
    /*
     * -------------<Summary>------------
     * Step 1: Run when called upon from other scripts, define int called amount
     * Step 2: Add the int to the CollectedCoin int
     * Step 3: Check if coins collected are 15 or more
     * Step 4: If so, Load next Scene (Check Library to have SceneManager)
     */

    // Step 1
    public void AddCollectedCoin(int amount)        // Call this method when a coin is collected.
    {
        // Step 2
        CollectedCoin += amount;                    // Add the int given, to CollectedCoin

        // Step 3
        if (CollectedCoin >= 2)                    // Check if CollectedCoin reaches 15.
        {
            // Step 4
            SceneManager.LoadScene("You Won!");     // Load the "Won" scene.
        }
        /* You can add any other logic here, such as updating a UI display of collected coins. */
    }

    void Update()
    {
        Pause();
    }

    //=============> Pause <============//
    /*
     * -----------> Summary <-----------
     * Step 1: Check if P is pressed
     * Step 2: Check if boolean isPaused is true
     * Step 3: IF it is Paused, then set TimeScale to 1.0f
     * Step 4: IF NOT then set the TimeScele to 0.0f (Which pauses the game)
     * Step 5: After the Bool loops, make sure you set the bool to not true
     */

    void Pause()
    {
        //Step 1
        if (Input.GetKeyDown(KeyCode.P))    // Check for player input to toggle pause
        {
            // Step 2
            if (isPaused)                   // Check to see Is Pause is true
            {
                // Step 3
                Time.timeScale = 1.0f;      // Unpause the game
            }
            else                            // Check to see Is Pause is false
            {
                // Step 4
                Time.timeScale = 0.0f;      // Pause Game
            }
            // Step 5
            isPaused = !isPaused;           // Set the Bool to false
        }
    }
}
