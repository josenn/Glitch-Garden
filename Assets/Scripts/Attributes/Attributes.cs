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
**      Module:              Attributes                          **
**                                                               **
**      File name:           Attributes.cs                       **
**                                                               **
**      Created by:          07/12/20            - JJR           **
**                                                               **
**      Description:         Holds values for Attacker           **
**                           and Defender stats                  **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
******************************************************************/

#endregion // STRUCT DEFINITION


#region USING DIRECTIVES

using System;
using System.Collections.Generic;
using UnityEngine;

#endregion // USING DIRECTIVES

#region ATTRIBUTES STRUCT DEFINITION
public struct Attributes
{
    #region PRIVATE VARIABLES

    private float health, damage;

    #endregion // PRIVATE VARIABLES

    #region PUBLIC FUNCTIONS

    public float GetHealth()
    {
        return health;
    }

    public float GetDamage()
    {
        return damage;
    }

    public void SetHealth(float healthToSet)
    {
        health = healthToSet;
    }

    public void SetDamage(float damageToSet)
    {
        damage = damageToSet;
    }

    #endregion // PUBLIC FUNCTIONS
}

#endregion // STRUCT DEFINITION
