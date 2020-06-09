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

public class Shooter : MonoBehaviour
{
	#region PRIVATE VARIABLES
	
	[SerializeField] private GameObject projectile, gun; // Might make this another type in the future to tighten it up

	#endregion

	#region UNITY FUNCTIONS

    void Start()
    {

    }

    void Update()
    {

    }
	
	#endregion

	#region PRIVATE FUNCTIONS

	/// <summary>Instantiates projectile</summary>
	/// <br />
	/// <remarks>Called from animation event</remarks>
	private void MakeProjectile()
	{
		//Debug.Log("Fire!");
		Instantiate(projectile, gun.transform.position, Quaternion.identity);
	}

	#endregion
} // Class Shooter

#endregion
