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
    [SerializeField] int timeUntilSceneLoads = 3;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
		Initialize();
        LoadStart();
    }

    #endregion // UNITY FUNCTIONS

	#region PRIVATE FUNCTIONS
	
	/// <summary>Initializes variables</summary>
	/// <br />
	/// <remarks> Acts as a sort of constructor</remarks>
	private void Initialize()
	{
		currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	}

	/// <summary>Loads the start scene</summary>
    private void LoadStart()
    {
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitTimeForSceneLoad());
        }
    }

	/// <summary>Loads the next scene after a certain amount of seconds<summary>
	/// <br />
	/// <remarks>This function is a Coroutine</remarks>
	/// <br />
	/// <returns>WaitForSeconds()</returns>
    private IEnumerator WaitTimeForSceneLoad()
    {
        yield return new WaitForSeconds(timeUntilSceneLoads); // Delay scene load

        LoadNextScene();
    }

	/// <summary>Loads the next scene</summary>
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
