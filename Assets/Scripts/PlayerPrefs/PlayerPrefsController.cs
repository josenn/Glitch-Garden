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
**      Module:              PlayerPrefs                         **
**                                                               **
**      File name:           PlayerPrefsController.cs            **
**                                                               **
**      Created by:          00/00/00            - JJR           **
**                                                               **
**      Description:         Controls PlayerPrefs                **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
******************************************************************/

#endregion // CLASS DEFINITION


#region USING DIRECTIVES

using System;
using System.Collections.Generic;
using UnityEngine;

#endregion // USING DIRECTIVES

#region PLAYERPREFSCONTROLLER CLASS DEFINITION
public class PlayerPrefsController : MonoBehaviour
/// <summary>Base class for the PlayerPrefsController (a wrapper for PlayerPrefs)</summary>
{
	#region PRIVATE VARIABLES

    private const string MASTER_VOLUME_KEY = "Master volume";
    private const string DIFFICULTY_KEY = "Difficulty";


    private const float MIN_VOLUME = 0.0f;
    private const float MAX_VOLUME = 1.0f;

    private const float MIN_DIFFICULTY = 0.0f;
    private const float MAX_DIFFICULTY = 2.0f;

    #endregion // PRIVATE VARIABLES

    #region PUBLIC FUNCTIONS

    /// <summary>Sets the game's master volume</summary>
    /// <br />
    /// <param name="volume">A float representing the volume to be set</param>
    public static void SetMasterVolume(float volume)
    {
        if((volume >= MIN_VOLUME) && (volume <= MAX_VOLUME))
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume is out of range");
        }
    }

    /// <summary>Sets the game's difficulty</summary>
    /// <br />
    /// <param name="difficulty">A float representing the difficulty to be set</param>
    public static void SetDifficulty(float difficulty)
    {
        if((difficulty >= MIN_DIFFICULTY) && (difficulty <= MAX_DIFFICULTY))
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty is out of range");
        }
    }

    /// <summary>Gets the game's Master volume setting</summary>
    /// <br />
    /// <returns>The volume that has been saved in PlayerPrefs</returns>
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    /// <summary>Gets the game's difficulty setting</summary>
    /// <br />
    /// <returns>The difficulty that has been saved in PlayerPrefs</returns>
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

    #endregion // PUBLIC FUNCTIONS

} // Class PlayerPrefsController

#endregion // CLASS DEFINITION
