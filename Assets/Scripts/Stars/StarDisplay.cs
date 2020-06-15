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
**      Module:              Star                                **
**                                                               **
**      File name:           StarDisplay.cs                      **
**                                                               **
**      Created by:          06/09/20            - JJR           **
**                                                               **
**      Description:         Controls the star system            **
**                                                               **
**      The star system is the game's resource system            **
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

#region STARDISPLAY CLASS DEFINITION

public class StarDisplay : MonoBehaviour
{
    #region PUBLIC VARIABLES

    #endregion // PUBLIC VARIABLES

	#region PRIVATE VARIABLES
    [SerializeField] private int amountOfStars = 100;

    Text starText;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    /// <summmary>Does the player have enough stars?</summary>
    /// <br />
    /// <param name="amount">An int representing the amount of stars a defender cost</param>
    /// <br />
    /// <returns>true or false depending on if the player has enough stars or not</returns>
    public bool HasEnoughStars(int amount)
    {
        /*if(stars >= amount)
        {
            return true; <---- an example of multiple ways to do things 
        }

        return false;*/ 
        
        return (amountOfStars >= amount);
    }
    
    /// <summary>Adds stars to the current star amount</summary>
    /// <br />
    /// <param name="amount">An int representing the amount of stars to be added</param>
    public void AddStars(int amount)
    {
        amountOfStars += amount;
        UpdateDisplay();
    }

     /// <summary>Allows the player to spend stars</summary>
     /// <br />
     /// <param name="amount">An int representing the amount of stars to be spent</param>
    public void SpendStars(int amount)
    {
        if(amountOfStars >= amount)
        {
            amountOfStars -= amount;
            UpdateDisplay();
        }
    }

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

    /// <summary>Updates the star text display</summary>
    private void UpdateDisplay()
    {
        starText.text = amountOfStars.ToString();
    }

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class StarDisplay

#endregion // CLASS DEFINITION
