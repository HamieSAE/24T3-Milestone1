using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //<==== Added Lib

//_____________________________________________________________________________||
//======================|                               |======================||
//======================| - >   Summary of Script   < - |======================||
//======================|                               |======================||
//=============================================================================||
//----->| There are two sections in this script, The Pause & BTN Manager <-----||
//-----------------------------------------------------------------------------||
// -| > In the Pause section, we are checking if Escape is pressed, if so,    -||
// -| pause the game and set the panel that has the pause mennu into active.   ||
//-----------------------------------------------------------------------------||
// -| > In the BTN Manager, we have two btn functionality,                    -||
// -| Function 1: Go to the scene thas been typed out in Inspector            -||
// -| Function 2: When BTN is pressed, Quit the Application                    ||
//=============================================================================||

public class BTNManager : MonoBehaviour
{
    //=========> Declaration <===========//
    public GameObject pauseCanvas;                              //Canvas We are showcasing when player presses pause.

    /*-----------------------------------> Start <----------------------------*/
    /* Just to set the mouse visible and unlock from the centre point*/

    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // UNLock cursor
        Cursor.visible = true; // Undo Hide cursor
    }

    //=========> Update <===========//
    /*Step 1: Check if escape is pressed, if so, do Step 2
     * Step 2: Run the custom Method
     */
    void Update()
    {
        //Step 1:
        if(Input.GetKeyDown(KeyCode.Escape))                    //If Escape is pressed do the thing
        {
            //Step 2:
            TogglePauseMenu();
        }
    }
    /*-----------------------------------------------> Custom Methods Down Below <-----------------------------------------------*/
    //=========> TogglePauseMenu <===========//
    /* Step 1: Do the oposite of the condision of activeness for Pause Canvas
     * Step 2: Depending on the Canvas availablity, set the time scale to 0f or 1f
     */
    public void TogglePauseMenu()
    {
        //Step 1:
        pauseCanvas.SetActive(!pauseCanvas.activeSelf);         //Swaps between active and inactive of game object pauseMenu
        //Step 2:
        Time.timeScale = pauseCanvas.activeSelf ? 0f : 1f;      //Chenges the time of game run depending of Pause menu
    }
    /*-------------------------------------------------> BTN Manager <---------------------------------------------------------*/
    //=========> NewLevelBtn <===========//
    /* Step 1: Create custom Method that takes in string
     * Step 2: Give command that loads in the next scene
     */
    //Step 1:
    public void NewLevelBtn(string newLevel)
    {
        //Step 2:
        SceneManager.LoadScene(newLevel);                      // Loads the scene that you name as string in Inspector
    }

    //=========> ExitGameBtn <===========//
    /* Step 1: Creat another custom method for Exitig the game.
     * Step 2: Quit the application
     */
    //Step 1: 
    public void ExitGameBtn()
    {
        //Step 2:
        Application.Quit();                                     // Exits the application
    }
}
