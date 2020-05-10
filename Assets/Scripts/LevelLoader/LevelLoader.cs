// #region CLASS DESCRIPTION
/******************************************************************
**                                                               **
**              Jonathan Renn                                    **
**                                                               **
**              Copyright (C) 2020 - All Rights Reserved         **
**                                                               **
*******************************************************************
**                                                               **
**      Project:             Glitch Garden                       **
**                                                               **
**      Module:              LevelLoader                         **
**                                                               **
**      File name:           LevelLoader.cs                      **
**                                                               **
**      Created by:          00/00/00            - JJR           **
**                                                               **
**      Description:         Loads scenes                        **
**                                                               **
** This class controls loading between various scenes such as    **
** the splash screen, start menu, and the game scene             **
**                                                               **
** With the potential for more levels to be added in the future  **
**                                                               **
**                                                               **
******************************************************************/

// This isn't actually under any copyright but I want to get in the habit of always including this
// #endregion

// #region USING DIRECTIVES
/******************************************************************
**                      Using Directives                         **
******************************************************************/
using System;
using System.Collections; /* IEnumertor is declared in this namespace */
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /* So we can use scene manager */
// #endregion

// #region LEVELLOADER CLASS DEFINITION
/******************************************************************
**                     Class Definition                          **
******************************************************************/
public class LevelLoader : MonoBehaviour
{
    // #region PRIVATE VARIABLES
    int currentSceneIndex; // The current scene (remember magic numbers are bad!)
    [SerializeField] int timeUntilStartMenuLoads = 3; // The time until the start menu loads
    // #endregion

    // #region START
    // Start is called before the first frame update
    void Start()
    {
		currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // Get the position of the scene in the build index
        LoadStart(); // Load the start scene
    }
    // #endregion

	// #region PRIVATE SUBROUTINES
	/******************************************************************
	**                     Private Subroutines                       **
	******************************************************************/
	/* If we're on the splash screen, load the start scene */
    private void LoadStart()
    {
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitTimeForSceneLoad());
        }
    }

	/* Loads the next scene after a certain amount of seconds
	   Makes it feel more organic
	*/
    private IEnumerator WaitTimeForSceneLoad()
    {
        /* Suspend the coroutine exectuion
           I originally thought that a return had to be at the end but it doesn't!
           This is like "Hey wait X seconds then come back and do stuff"
		*/
        yield return new WaitForSeconds(timeUntilStartMenuLoads);

        LoadNextScene();
    }

	/* Load the next scene */
    private void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
	// #endregion

	// #region TODOS
	// TODO add fade in/out between scene loads
	// #endregion

} // Class LevelLoader
// #endregion
