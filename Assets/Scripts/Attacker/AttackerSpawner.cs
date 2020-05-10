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
**      Module:              Attacker Spawner                    **
**                                                               **
**      File name:           AttackerSpawner.cs                  **
**                                                               **
**      Created by:          05/07/20            - JJR           **
**                                                               **
**      Description:         Spawns Attcakers                    **
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

// #region CLASS DEFINITION
/******************************************************************
**                     Class Definition                          **
******************************************************************/
public class AttackerSpawner : MonoBehaviour
{
	// #region PRIVATE VARIABLES
	bool spawnAttackers;
	float minTimeUntilSpawn;
	float maxTimeUntilSpawn;
	[SerializeField] Attacker attackerPrefab;
	// #endregion

	// #region START
    // Start is called before the first frame update
    IEnumerator Start()
	{
		Initialize();
		while(spawnAttackers) // No end condition yet but that's okay!
		{
			yield return new WaitForSeconds(Random.Range(minTimeUntilSpawn, maxTimeUntilSpawn));
			SpawnAttackers();
		}
	}
	// #endregion

	// #region UPDATE
    // Update is called once per frame
    void Update()
    {

    }
	// #endregion

	// #region PRIVATE SUBROUTINES
	void Initialize()
	{
		spawnAttackers = true;
		minTimeUntilSpawn = 0;
		maxTimeUntilSpawn = 5;
	}

	void SpawnAttackers()
	{
		Instantiate(attackerPrefab, transform.position, Quaternion.identity);
	}
	// #endregion

} // AttackerSpawner
// #endregion
