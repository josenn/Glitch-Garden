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
**      Module:              Level                               **
**                                                               **
**      File name:           LevelController.cs                  **
**                                                               **
**      Created by:          06/17/20            - JJR           **
**                                                               **
**      Description:         Controls the game's                 **
**                           LevelController                     **
**      The LevelController tracks the game's win/lose condtions **
**      and things like that                                     **
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

#endregion // USING DIRECTIVES

#region LEVELCONTROLLER CLASS DEFINITION
/// <summary>Base class for the game's Level Controller</summary>
/// <remarks>The level controller tracks the game's win/lose conditions and things like that</remarks>
public class LevelController : MonoBehaviour
{
	#region PRIVATE VARIABLES
    
    private bool gameTimerFinished = false;
    [SerializeField] private int numberOfAttackers = 0;
    [SerializeField] private float waitTime = 3.0f;
    [SerializeField] private GameObject levelCompleteCanvas = null;
    [SerializeField] private GameObject gameOverCanvas = null;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        levelCompleteCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    /// <summary>Increases the numberOfAttackers by one each time an Attacker is spawned</summary>
    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    /// <summary>Decreases the numberOfAttackers by one each time an Attacker is killed</summary>
    public void AttackerKilled()
    {
        numberOfAttackers--;

        if((numberOfAttackers <= 0) && gameTimerFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    /// <summary>Is the timer finished? (i.e. has the slider reaches the end?)</summary>
    public void GameTimerFinished()
    {
       gameTimerFinished = true;
       StopSpawners();
    }

    /// <summary>Gets the gameOverCanvas variable</summary>
    /// <returns>gameOverCanvas</returns>
    public GameObject GetGameOverCanvas()
    {
        return gameOverCanvas;
    }

    /// <summary>Handle's the game's lose condition</summary>
    public void HandleLoseCondition()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }


    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

    /// <summary>Stops the attacker spawners from spawning</summary>
    private void StopSpawners()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner attackerSpawner in attackerSpawners)
        {
            attackerSpawner.StopSpawning();
        }
    }

    /// <summary>Handles the game's win condition</summary>
    private IEnumerator HandleWinCondition()
    {
        levelCompleteCanvas.SetActive(true);

        GetComponent<AudioSource>().Play();
        
        yield return new WaitForSeconds(waitTime);

        GetComponent<LevelLoader>().LoadNextScene();
    }
    
	#endregion // PRIVATE FUNCTIONS

} // Class LevelController

#endregion // CLASS DEFINITION
