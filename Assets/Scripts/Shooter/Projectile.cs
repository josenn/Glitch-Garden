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
/// <summary>Base class for projectiles</summary>
public class Projectile : MonoBehaviour
{
	#region PRIVATE VARIABLES

	[SerializeField] private float projectileSpeed = 2.0f;
	[SerializeField] private float damage = 100.0f;

	#endregion // PRIVATE VARIABLES

	#region UNITY FUNCTIONS

    private void Update()
    {
		Fire();
    }

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

	/// <summary>Fires projectile</summary>
	private void Fire()
	{
		transform.Translate(projectileSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World);
	}

	#endregion // PRIVATE FUNCTIONS

} // Class Projectile

#endregion // CLASS DEFINITION
