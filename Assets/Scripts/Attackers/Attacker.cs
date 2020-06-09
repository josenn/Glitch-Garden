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
**      File name:           Attacker.cs                         **
**                                                               **
**      Created by:          05/06/20            - JJR           **
**                                                               **
**      Description:         Controls functionality              **
**                           for Attackers                       **
**                                                               **
**     This script controls the attackers that are in the game   **
**     Attackers are the same thing as enemies                   **
**     Variables and subroutine descriptions will be present     **
**     with said variables and FUNCTIONS                         **
**                                                               **
**                                                               **
******************************************************************/

// This isn't actually under any copyright but I want to get in the habit of always including this

#endregion // CLASS DESCRIPTION

#region USING DIRECTIVES

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#endregion // USING DIRECTIVES

#region ATTACKER CLASS DEFINITION
public class Attacker : MonoBehaviour
{
	#region PRIVATE VARIABLES

	private float currentSpeed;

	#endregion // PRIVATE VARIABLES

	#region UNITY FUNCTIONS

    void Start()
    {
		Initialize();
    }
	
    void Update()
    {
		transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

	#endregion // UNITY FUNCTIONS

	#region PUBLIC FUNCTIONS

	/*
	 * PURPOSE : Sets attacker movement speed
	 *  PARAMS : Speed (float)
	 * RETURNS : void
	 *   NOTES : Called from an animation event
	 *
	 */
	public void SetMovementSpeed(float speed)
	{
		//Debug.Log("Setting the movement speed");
		currentSpeed = speed;
	}
	#endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

	/*
	 * PURPOSE : Initializes variables
	 *  PARAMS : None
	 * RETURNS : void
	 *   NOTES : Acts as a sort of constructor
	 *           (since using constructors on MonoBehaviour inheritors is a no-no)
	 */
	private void Initialize()
	{
		currentSpeed = 1f;
	}

	#endregion // PRIVATE FUNCTIONS

} // Class Attacker

 #endregion // CLASS DEFINITION
