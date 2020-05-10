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
**     TODO                                                      **
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
	[RangeAttribute(0f, 5f)][SerializeField] float attackerMoveSpeed = 1f;
	// #endregion

	// #region START
	// Start is called before the first frame update
    void Start()
    {
		
    }
	// #endregion

	// #region UPDATE
    // Update is called once per frame
    void Update()
    {
		transform.Translate(Vector2.left * Time.deltaTime * attackerMoveSpeed);
    }
	// #endregion

} // Class Attacker
// #endregion
