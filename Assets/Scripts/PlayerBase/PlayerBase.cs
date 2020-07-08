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
**      Module:              PlayerBase                          **
**                                                               **
**      File name:           PlayerBase.cs                       **
**                                                               **
**      Created by:          06/17/20            - JJR           **
**                                                               **
**      Description:         Controls the Player's base          **
**                                                               **
**      Things like attackers dealing damage to it and the       **
**      player losing the game etc                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
******************************************************************/

#endregion // CLASS DEFINITION


#region USING DIRECTIVES

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#endregion // USING DIRECTIVES

#region PLAYERBASE CLASS DEFINITION
/// <summary>Base class for the Player's base</summary>
public class PlayerBase : MonoBehaviour
{
	#region PRIVATE VARIABLES

    [SerializeField] private int playerBaseHealth = 100;
    [SerializeField] private float timeUntilGameOverLoads = 3.0f;
    [SerializeField] private Text playerBaseHealthText = null;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
        UpdatePlayerBaseHealthDisplay();
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        // if attacker enters
            // decrease player base health
        if(otherObject.GetComponent<Attacker>())
        {
            int damageDealt = otherObject.GetComponent<Attacker>().GetDamage();

            playerBaseHealth -= damageDealt;

            UpdatePlayerBaseHealthDisplay();
        }

        // if health is less than or equal to 0
            // lose the game
        if(playerBaseHealth <= 0)
        {
            // lose the game
            StartCoroutine(TriggerGameOver());
        }
    }

    #endregion // UNITY FUNCTIONS

	#region PRIVATE FUNCTIONS

    /// <summary>Updates the health display for the player's base</summary>
    private void UpdatePlayerBaseHealthDisplay()
    {
        playerBaseHealthText.text = playerBaseHealth.ToString();
    }

    /// <summary>A helper for the HandleWinCondition function</summary>
    private IEnumerator TriggerGameOver()
    {
        FindObjectOfType<DefenderSpawner>().SetIsGameOver(true);

        yield return new WaitForSeconds(timeUntilGameOverLoads);

        FindObjectOfType<LevelController>().HandleLoseCondition();

    }
    
	#endregion // PRIVATE FUNCTIONS

} // Class PlayerBase

#endregion // CLASS DEFINITION
