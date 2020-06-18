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

	[SerializeField]private float currentSpeed = 1;
	private GameObject currentTarget; // Might change type later
	private Animator attackerAnimator;

	[SerializeField] private int damage = 5; // The amount of damage Attackers do to the player's base

	#endregion // PRIVATE VARIABLES

	#region UNITY FUNCTIONS

	private void Start()
	{
		attackerAnimator = GetComponent<Animator>();
	}

    private void Update()
    {
		MoveAttacker();
		CheckForTarget();
    }

	#endregion // UNITY FUNCTIONS

	#region PUBLIC FUNCTIONS

	/// <summary>Sets attacker movement speed</summary>
	/// <br />
	/// <param name= "speed">A float representing the speed to set</param>
	/// <br />
	/// <remarks>This function is called from an animation event on an attacker</remarks>
	public void SetMovementSpeed(float speed)
	{
		//Debug.Log("Setting the movement speed");
		currentSpeed = speed;
	}

	/// <summary>Makes an attacker attack</summary>
	/// <br />
	/// <param name="target">The GameObject to target for an attack</param>
	public void Attack(GameObject target)
	{
		attackerAnimator.SetBool("isAttacking", true); // Change animation state
		currentTarget = target;
	}

	/// <summary></summary>
	public void StrikeCurrentTarget(float damage)
	{
		// if you don't have a current target do nothing
		if(!currentTarget) { return; }

		Health health = currentTarget.GetComponent<Health>();

		if(health)
		{
			health.DealDamage(damage);
		}
	}

	public int GetDamage()
	{
		return damage;
	}
	
	#endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

	/// <summary> Moves attackers</summary>
	private void MoveAttacker()
	{
		transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
	}

	///<summary>Checks to see if an attacker has a currentTarget, if not changes animation to state to walking</summary>
	private void CheckForTarget()
	{
		if(!currentTarget)
		{
			attackerAnimator.SetBool("isAttacking", false); 
		}
	}

	#endregion // PRIVATE FUNCTIONS

} // Class Attacker

 #endregion // CLASS DEFINITION
