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
// #endregion

// #region USING DIRECTIVES
/******************************************************************
**                      Using Directives                         **
******************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// #endregion

// #region ATTACKER CLASS DEFINITION
/******************************************************************
**                     Class Definition                          **
******************************************************************/
public class Shooter : MonoBehaviour
{
	// #region PRIVATE VARIABLES
	/******************************************************************
	**                     Private Variables                         **
	******************************************************************/
	[SerializeField] private GameObject projectile, gun; // Might make this another type in the future to tighten it up
	// #endregion

	/******************************************************************
	**                     Unity Subroutines                         **
	******************************************************************/
	// #region START
    void Start()
    {

    }
	// #endregion

	// #region UPDATE
    void Update()
    {

    }
	// #endregion

	// #region PRIVATE SUBROUTINES
	/******************************************************************
	**                     Private Subroutines                       **
	******************************************************************/

	/*
	 * PURPOSE : Fire projectile
	 *  PARAMS : None
	 * RETURNS : void
	 *   NOTES : Called from an animation event
	 *
	 */
	private void Fire()
	{
		//Debug.Log("Fire!");
		Instantiate(projectile, gun.transform.position, Quaternion.identity);
	}
	// #endregion
} // Shooter
// #endregion
