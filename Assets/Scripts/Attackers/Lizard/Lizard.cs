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
**      Module:              Attackers                           **
**                                                               **
**      File name:           Lizard.cs                           **
**                                                               **
**      Created by:          06/15/20            - JJR           **
**                                                               **
**      Description:         Controls certain properties         **
**                           of the lizard attacker              **
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

#region LIZARD CLASS DEFINITION

public class Lizard : MonoBehaviour
{
    #region PUBLIC VARIABLES

    #endregion // PUBLIC VARIABLES

	#region PRIVATE VARIABLES


    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        if(otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class Lizard

#endregion // CLASS DEFINITION
