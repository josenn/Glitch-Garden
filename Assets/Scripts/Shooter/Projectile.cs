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
**      Module:              Projectile                          **
**                                                               **
**      File name:           Projectile.cs                       **
**                                                               **
**      Created by:          05/22/20            - JJR           **
**                                                               **
**      Description:         Turns things into projectiles       **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
******************************************************************/

// This isn't actually under any copyright but I want to get in the habit of always including this

#endregion // CLASS DESCRIPTION

#region USING DIRECTIVES

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#endregion // USING DIRECTIVES

#region PROJECTILE CLASS DEFINITION
public class Projectile : MonoBehaviour
{
	 #region PRIVATE VARIABLES

	private float projectileSpeed;
	private float rotationSpeed;
	[SerializeField] private float damage;

	#endregion // PRIVATE VARIABLES

	#region UNITY FUNCTIONS
    void Start()
    {
		Initialize();
    }

    void Update()
    {
		Fire();
		//Debug.Log("Firing!");
    }

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	private void OnTriggerEnter2D(Collider2D other)
	{
		var health = other.GetComponent<Health>();
		var attacker = other.GetComponent<Attacker>();

		// If they're an attacker and they have health
		if(attacker && health)
		{
			health.DealDamage(damage);
			Destroy(gameObject);
		}
	}

	#endregion // UNITY FUNCTIONS

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
		projectileSpeed = 5.0f;
		rotationSpeed = 45.0f;
		damage = 100.0f;
	}
	
	/*
	 * PURPOSE : Fire projectile
	 *  PARAMS : None
	 * RETURNS : void
	 *   NOTES :
	 *
	 */
	private void Fire()
	{
		//Debug.Log("Firing!");
		transform.Translate(projectileSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World);
		transform.Rotate(0.0f, 0.0f, rotationSpeed);
	}

	#endregion // PRIVATE FUNCTIONS

} // Class Projectile

#endregion // CLASS DEFINITION
