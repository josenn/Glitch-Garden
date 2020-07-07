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
/// <summary>Base class for Attacker Spawners</summary>
public class AttackerSpawner : MonoBehaviour
{
	#region PRIVATE VARIABLES

	[SerializeField] private bool spawnAttackers = true;
	[SerializeField] private float minTimeUntilSpawn = 0.0f;
	[SerializeField] private float maxTimeUntilSpawn = 5.0f;
	[SerializeField] Attacker[] attackerPrefabs = null;

	#endregion // PRIVATE VARIABLES

	#region UNITY FUNCTIONS

    private IEnumerator Start()
	{
		//yield return new WaitForSeconds(30); delay spawning so player can get a little prepared.

		while(spawnAttackers)
		{
			yield return new WaitForSeconds(Random.Range(minTimeUntilSpawn, maxTimeUntilSpawn));
			SpawnAttackers();
		}
	}

	#endregion // UNITY FUNCTIONS

	#region PRIVATE FUNCTIONS

	/// <summary>Initializes variables</summary>
	/// <remarks> Acts as a sort of constructor</remarks>
	/*private void Initialize()
	{
		spawnAttackers = true;
		minTimeUntilSpawn = 0;
		maxTimeUntilSpawn = 5;
	}*/

	private void Spawn(Attacker attacker)
	{
		Attacker newAttacker = Instantiate(attacker, transform.position, Quaternion.identity);

		newAttacker.transform.parent = transform; // Makes newAttacker the child of any AttackerSpawner
	}

	/// <summary>Spawns attackers</summary>
	private void SpawnAttackers()
	{
		var attackerIndex = Random.Range(0, attackerPrefabs.Length);
		Spawn(attackerPrefabs[attackerIndex]);
	}

	#endregion // PRIVATE SUBROTINES
	
} // Class AttackerSpawner

#endregion // CLASS DEFINITION