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
/// <summary>Base class for the gane's health system</summary> // Should have multiple scripts instead?
public class Health : MonoBehaviour
{
	#region PRIVATE VARIABLES

	[SerializeField] private float currentHealth = 100.0f;
    [SerializeField] private ParticleSystem deathFX = null;

	#endregion // PRIVATE VARIABLES

    #region PUBLIC FUNCTIONS

    /// <summary>Deals damage to an object (defender or attacker)</summary>
    /// <br />
    /// <param name= "damage">A float representing the damage to be dealt</param>
    /// <remarks>Called from an animation event</remarks>
    public void DealDamage(float damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            TriggerDeathFX();
            Destroy(gameObject);
        }
    }

    /// <summary>Sets an Attacker or Defender's health</summary>
    /// <br />
    /// <param name="health">A float representing the health to set</param>
    public void SetHealth(float health)
    {
        currentHealth = health;
    }

    /// <summary>Gets an Attacker or Defender's health</summary>
    /// <br />
    /// <returns>A float representing the health of an Attacker or Defender</returns>
    public float GetHealth()
    {
        return currentHealth;
    }

    #endregion // PUBLIC FUNCTIONS

    #region PRIVATE FUNCTIONS

    /// <summary>Triggers deathFX when an object is destroyed</summary>
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