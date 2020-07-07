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
/// <summary>Base class for Lizard Attackers</summary>
/// <remarks>Lizards do not have a special ability</summary>
public class Lizard : MonoBehaviour
{
    #region UNITY FUNCTIONS

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        if(otherObject.GetComponent<Defender>()) // If it's a Defender
        {
            GetComponent<Attacker>().Attack(otherObject); // Attack
        }
    }

    #endregion // UNITY FUNCTIONS
    
} // Class Lizard

#endregion // CLASS DEFINITION
