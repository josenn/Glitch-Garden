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
		MoveAttacker();
    }

	#endregion // UNITY FUNCTIONS

	#region PUBLIC FUNCTIONS

	/// <summary>Sets attacker movement speed</summary>
	/// <br />
	/// <param name= "speed">A float representing the speed to set</param>
	/// <br />
	/// <remarks> This function is called from an animation event</remarks>
	public void SetMovementSpeed(float speed)
	{
		//Debug.Log("Setting the movement speed");
		currentSpeed = speed;
	}
	
	#endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

	/// <summary>Initializes variables</summary>
	/// <br />
	/// <remarks> Acts as a sort of constructor</remarks>
	private void Initialize()
	{
		currentSpeed = 1f;
	}

	/// <summary> Moves attackers</summary>
	private void MoveAttacker()
	{
		transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
	}

	#endregion // PRIVATE FUNCTIONS

} // Class Attacker

 #endregion // CLASS DEFINITION
