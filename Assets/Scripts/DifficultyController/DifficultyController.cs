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
**      Module:              DifficultyController                **
**                                                               **
**      File name:           DifficultyController.cs             **
**                                                               **
**      Created by:          06/25/20            - JJR           **
**                                                               **
**      Description:         Control's the game's difficulty     **
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

#region DIFFICULTYCONTROLLER CLASS DEFINITION
/// <summary>Base class for the Difficulty Controller</summary>
/// TODO - UNFINISHED - NOT SURE WHAT I WANT TO DO WITH DIFFICULTY YET
public class DifficultyController : MonoBehaviour
{
	#region PRIVATE VARIABLES

    private static float difficulty;
    private float healthToSet, damageToSet, speedToSet, projectileSpeedToSet, starCostToSet;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
        difficulty = PlayerPrefsController.GetDifficulty();

        UpdateDifficulty();
    }

    #endregion // UNITY FUNCTIONS

	#region PRIVATE FUNCTIONS

    private void UpdateDifficulty()
    {
        switch(difficulty)
        {
            case 0: // Easy mode
                
                
            break;
            case 1: // Normal mode

            break;
            case 2: // Hard mode

            break;
        }
    }

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class DifficultyController

#endregion // CLASS DEFINITION
