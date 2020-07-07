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
**      Module:              Shooter                             **
**                                                               **
**      File name:           Shooter.cs                          **
**                                                               **
**      Created by:          05/21/20            - JJR           **
**                                                               **
**      Description:          Controls functionality for         **
**                            projectiles                        **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
******************************************************************/

// This isn't actually under any copyright but I want to get in the habit of always including this

#endregion

#region USING DIRECTIVES

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#endregion

#region SHOOTER CLASS DEFINITION
/// <summary>Base class for shooting projectiles</summary>
public class Shooter : MonoBehaviour
{
	#region PRIVATE VARIABLES
	
	[SerializeField] private Projectile projectile = null;
	[SerializeField] private GameObject gun = null;
	private AttackerSpawner myLaneSpawner;
	private Animator animator;

	#endregion

	#region UNITY FUNCTIONS

	private void Start()
	{
		animator = GetComponent<Animator>();
		SetLaneSpawner();
	}

	private void Update()
	{
		if(IsAttackerInLane())
		{
			animator.SetBool("isAttacking", true);

		}
		else
		{	
			animator.SetBool("isAttacking", false);
		}
	}

	#endregion

	#region PRIVATE FUNCTIONS

	/// <summary>Instantiates projectile</summary>
	/// <br />
	/// <remarks>Called from animation event on defenders</remarks>
	private void MakeProjectile()
	{
		Projectile newProjectile = Instantiate(projectile, gun.transform.position, Quaternion.identity, gun.transform);
	}

	/// <summary>Sets the spawner in a defenders lane</summary>
	/// <br />
	/// <remarks>If a defender and a spawner have the same y value for their transform they are in the same lane</remarks>
	private void SetLaneSpawner()
	{
		AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
     
		foreach(AttackerSpawner attackerSpawner in attackerSpawners)
		{
			#region SETLANESPAWNER LONG COMMENT

			// This is so the Cactus (shooter) knows if there's an attacker on his lane.
            // If the spawner and defender are on the same lane, that means their Y axis is 0.
            // We don't use 0 here because computers love messing up with numbers so we use 
			// "Mathf.Episolon" which means: smallest number found.
            // (Mathf.Abs()) is for when you don't want a negative number, it will make it positive (absolute).
			
			#endregion

			bool isCloseEnough = (Mathf.Abs(attackerSpawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

			// If I look in the array and find someone who's on the same Y axis...
			if(isCloseEnough)
			{
				// Then I'll consider it "my spawner" and I can apply some methods on him only and not mess with the others.
				myLaneSpawner = attackerSpawner;
			}
		}
	}

	/// <summary>Is there an attacker currently in your lane?</summary>
	/// <br />
	/// <para>
	/// Checks if the laneSpawner in the defender's lane has any children. 
	/// If it does we know there is an attacker in the lane
	/// </para>
	private bool IsAttackerInLane()
	{
		// if there is no lane spawner in the lane
			// return false (without this (Unity will throw a nullReferenceException)
		if(!myLaneSpawner)
		{
			Debug.Log("No spawner detected!");
			return false;
		}

		// if my lane spawner child count is less than or equal to 0
			// return false
		if(myLaneSpawner.transform.childCount <= 0)
		{
			return false;
		}

		return true;
	}

	#endregion // PRIVATE FUNCTIONS

} // Class Shooter

#endregion // CLASS DEFINITION
