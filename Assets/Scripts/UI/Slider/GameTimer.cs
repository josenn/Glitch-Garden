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
**      Module:              UI/Slider                           **
**                                                               **
**      File name:           GameTimer.cs                        **
**                                                               **
**      Created by:          06/17/20            - JJR           **
**                                                               **
**      Description:         Controls the in game timer          **
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
using UnityEngine.UI;

#endregion // USING DIRECTIVES

#region GAME_TIMER CLASS DEFINITION
/// <summary>Base class for the Game Timer</summary>
public class GameTimer : MonoBehaviour
{
	#region PRIVATE VARIABLES

    [Tooltip("Game timer in seconds")]
    [SerializeField] private float gameTime = 10.0f;
    private bool timerFinished;
    private bool triggerLevelFinish;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Update()
    {
        CheckLevelFinishedState();
        
        UpdateGameTime();

        CheckTimerFinished();
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    /// <summary>Gets the timerFinished variable</summary>
    /// <br />
    /// <returns>timerFinished</returns>
    public bool GetTimerFinished()
    {
        return timerFinished;
    }

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

    /// <summary>Updates the game timer slider</summary>
    private void UpdateGameTime()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / gameTime;

        timerFinished = (Time.timeSinceLevelLoad >= gameTime);
    }

    /// <summary>Checks if the timer has reached the end</summary>
    private void CheckTimerFinished()
    {
        if(timerFinished)
        {
            FindObjectOfType<LevelController>().GameTimerFinished();
            triggerLevelFinish = true;
        }
    }

    /// <summary></summary>
    private void CheckLevelFinishedState()
    {
        // if it's time to finish the level stop
        if(triggerLevelFinish) 
        { 
            return; 
        }

    }

	#endregion // PRIVATE FUNCTIONS

} // Class GameTimer

#endregion // CLASS DEFINITION
