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
**      Module:              Health                              **
**                                                               **
**      File name:           Health.cs                           **
**                                                               **
**      Created by:          05/24/20            - JJR           **
**                                                               **
**      Description:         Controls a character's health       **
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

#region HEALTH CLASS DEFINITION
public class Health : MonoBehaviour
{
	 #region PRIVATE VARIABLES

	[SerializeField] private float health;
    [SerializeField] private ParticleSystem deathFX;

	#endregion // PRIVATE VARIABLES

	#region UNITY FUNCTIONS
    void Start()
    {
        health = 100.0f;
    }

    void Update()
    {
		//Debug.Log("Firing!");
    }

	#endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    public void DealDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            TriggerDeathFX();
            Destroy(gameObject);
        }
    }

    #endregion // PUBLIC FUNCTIONS

    #region PRIVATE FUNCTIONS

    private void TriggerDeathFX()
    {
        if(!deathFX)
        {
            Debug.Log("Death Effect not found (did you forget to add it to the gameObject?");
            return;
        }

        Instantiate(deathFX, transform.position, Quaternion.identity);
    }

    #endregion // PRIVATE FUNCTIONS

} // Class Health

#endregion // CLASS DEFINITION