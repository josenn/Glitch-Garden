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
**      Module:              Attacker                            **
**                                                               **
**      File name:           Fox.cs                              **
**                                                               **
**      Created by:          06/17/20            - JJR           **
**                                                               **
**      Description:         Controls certain properties of the  **
**                           Fox attacker                        **
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

#region FOX CLASS DEFINITION
/// <summary>Base class for Fox Attackers</summary>
/// <br />
/// <remarks>Fox's special is the ability to jump over Gravestone Defenders</remarks>
public class Fox : MonoBehaviour
{
	#region PRIVATE VARIABLES

    private Animator foxAnimator;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
        foxAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        if(otherObject.GetComponent<Gravestone>()) // Trigger jump to get past the Gravestone Defender
        {
            TriggerJump();
        }
        else if(otherObject.GetComponent<Defender>()) // Attack if it is any other Defender
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }

    #endregion // UNITY FUNCTIONS

	#region PRIVATE FUNCTIONS

    /// <summary>Trigger Fox jump animation</summary>
    /// <remarks>Uses foxAnimator to set a trigger that triggers the jump animation</remarks>
    private void TriggerJump()
    {
        foxAnimator.SetTrigger("jumpTrigger");
    }

	#endregion // PRIVATE FUNCTIONS

} // Class Fox

#endregion // CLASS DEFINITION
