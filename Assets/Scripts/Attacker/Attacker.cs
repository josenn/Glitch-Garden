// #region CLASS DESCRIPTION
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
**     with said variables and subroutines                       **
**                                                               **
**                                                               **
******************************************************************/

// This isn't actually under any copyright but I want to get in the habit of always including this
// #endregion

// #region USING DIRECTIVES
/******************************************************************
**                      Using Directives                         **
******************************************************************/
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// #endregion

// #region ATTACKER CLASS DEFINITION
/******************************************************************
**                     Class Definition                          **
******************************************************************/
public class Attacker : MonoBehaviour
{
	// #region PRIVATE VARIABLES
	/******************************************************************
	**                     Private Variables                         **
	******************************************************************/
	private float currentSpeed;
	// #endregion

	/******************************************************************
	**                     Unity Subroutines                         **
	******************************************************************/
	// #region START
    void Start()
    {
		Initialize();
    }
	// #endregion

	// #region UPDATE
    void Update()
    {
		transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }
	// #endregion

	// #region PUBLIC SUBROUTINES
	/******************************************************************
	**                     Public Subroutines                        **
	******************************************************************/
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
	// #endregion

	// #region PRIVATE SUBROUTINES
	/******************************************************************
	**                     Private Subroutines                       **
	******************************************************************/
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
	// #endregion
} // Class Attacker
// #endregion
