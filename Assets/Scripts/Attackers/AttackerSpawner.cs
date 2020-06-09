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
**      Module:              Attacker Spawner                    **
**                                                               **
**      File name:           AttackerSpawner.cs                  **
**                                                               **
**      Created by:          05/07/20            - JJR           **
**                                                               **
**      Description:         Spawns Attcakers                    **
**                                                               **
**      This class is used for spawning the attackers            **
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

#region CLASS DEFINITION
public class AttackerSpawner : MonoBehaviour
{
	#region PRIVATE VARIABLES

	bool spawnAttackers;
	float minTimeUntilSpawn;
	float maxTimeUntilSpawn;
	[SerializeField] Attacker attackerPrefab;

	#endregion // PRIVATE VARIABLES

	#region UNITY FUNCTIONS
    IEnumerator Start()
	{
		Initialize();
		while(spawnAttackers) // No end condition yet but that's okay!
		{
			yield return new WaitForSeconds(Random.Range(minTimeUntilSpawn, maxTimeUntilSpawn));
			SpawnAttackers();
		}
	}

    void Update()
    {

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
		spawnAttackers = true;
		minTimeUntilSpawn = 0;
		maxTimeUntilSpawn = 5;
	}

	/*
     * PURPOSE : Spawns Attackers
     *  PARAMS : None
     * RETURNS : void
     *   NOTES :
	 *
	 */
	private void SpawnAttackers()
	{
		Instantiate(attackerPrefab, transform.position, Quaternion.identity);
	}

	#endregion // PRIVATE SUBROTINES
	
} // Class AttackerSpawner

#endregion // CLASS DEFINITION