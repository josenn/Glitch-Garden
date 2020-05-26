#region CLASS DESCRIPTION

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

#endregion // CLASS DEFINITION


#region USING DIRECTIVES

using System;
using System.Collections; /* IEnumertor is declared in this namespace */
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /* So we can use scene manager */

#endregion // USING DIRECTIVES


#region LEVELLOADER CLASS DEFINITION
public class LevelLoader : MonoBehaviour
{
	#region PRIVATE VARIABLES

    int currentSceneIndex;
    [SerializeField] int timeUntilSceneLoads;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    void Start()
    {
		Initialize();
        LoadStart();
    }

    #endregion // UNITY FUNCTIONS

	#region PRIVATE FUNCTIONS
	
	/*
	 * PURPOSE : Initializes variables
	 *  PARAMS : None
	 * RETURNS : void
	 *   NOTES : Acts as a sort of constructor
	 *           (since using constructors on MonoBehaviour inheritors is a no-no)
	 */
	private void Initialize()
	{
		currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		timeUntilSceneLoads = 3;
	}

	/*
	 * PURPOSE : Loads the start scene
	 *  PARAMS : None
	 * RETURNS : void
	 *   NOTES :
	 *
	 */
    private void LoadStart()
    {
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitTimeForSceneLoad());
        }
    }

	/*
	 * PURPOSE : Loads the next scene after a certain amount of seconds
	 *  PARAMS : None
	 * RETURNS : void
	 *  FUNCTION CALLS: LoadNextScene()
	 *   NOTES : Makes it feel more organic
	 *
	 */
    private IEnumerator WaitTimeForSceneLoad()
    {
        /* Suspend the coroutine exectuion
           I originally thought that a return had to be at the end but it doesn't!
           This is like "Hey wait X seconds then come back and do stuff"
		*/
        yield return new WaitForSeconds(timeUntilSceneLoads);

        LoadNextScene();
    }

	/*
	 * PURPOSE : Loads the next scene
	 *  PARAMS : None
	 * RETURNS : void
	 *   NOTES :
	 *
	 */
    private void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	// TODO add fade in/out between scene loads

	#endregion // TODOS

} // Class LevelLoader

#endregion // CLASS DEFINITION
