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
    #region PUBLIC VARIABLES

    #endregion // PUBLIC VARIABLES

	#region PRIVATE VARIABLES

    [Tooltip("Game timer in seconds")]
    [SerializeField] private float gameTime = 10.0f;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / gameTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= gameTime);

        if(timerFinished)
        {
            Debug.Log("Game timer expired!!");
        }
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class GameTimer

#endregion // CLASS DEFINITION
