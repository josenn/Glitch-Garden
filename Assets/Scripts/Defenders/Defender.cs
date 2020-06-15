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
**      Module:              Defender                            **
**                                                               **
**      File name:           Defender.cs                         **
**                                                               **
**      Created by:          06/09/20            - JJR           **
**                                                               **
**      Description:         Controls certain properties         **
**                           of defenders                        **
**       Controls only the star system as it relates to          **
**       defenders at the moment                                 **
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

#region DEFENDER CLASS DEFINITION
public class Defender : MonoBehaviour
{
    #region PUBLIC VARIABLES

    #endregion // PUBLIC VARIABLES

	#region PRIVATE VARIABLES

    [SerializeField] private int starCost = 100;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    /// <summary>Gets the amount of stars a defender costs</summary>
    /// <br />
    /// <returns>starCost</returns>
    public int GetStarCost() 
    { 
        return starCost; 
    }

    /// <summary>Adds stars to the current star amount</summary>
    /// <br />
    /// <param name= "amount">An int representing the amount of stars to be added</param>
    /// <br />
    /// <remarks>
    /// This calls the AddStars function in StarDisplay and is called 
    /// from an animation event on the trophy prefab(I needed a way of accessing AddStars)
    /// </remarks>
    public void AddStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class Defender

#endregion // CLASS DEFINITION
