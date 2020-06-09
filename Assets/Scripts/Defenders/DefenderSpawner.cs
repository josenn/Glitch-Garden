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
**      Module:              Defender                            **
**                                                               **
**      File name:           DefenderSpawner.cs                  **
**                                                               **
**      Created by:          00/00/00            - JJR           **
**                                                               **
**      Description:         Controls spawning of defenders      **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
**                                                               **
******************************************************************/

#endregion // CLASS DEFINITION

#region USING DIRECTIVES

using System;
using System.Collections.Generic;
using UnityEngine;

#endregion // USING DIRECTIVES

#region DEFENDER CLASS DEFINITION

public class DefenderSpawner : MonoBehaviour
{
    #region PUBLIC VARIABLES

    #endregion // PUBLIC VARIABLES

	#region PRIVATE VARIABLES

    private Defender defender;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
        
    }

    private void Update()
    {

    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    private void OnMouseDown()
    {
        //Debug.Log("Mouse has been clicked!!");
        SpawnDefender(GetSquareClicked());
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    /// <summary>Sets the defender the player selected</summary>
    /// <br />
    /// <param name= "defenderToSelect">The defender the player selected</param>
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS
    
    /// <summary>Gets the square the player clicked</summary>
    /// <br />
    /// <para>Converts the screen position of the mouse into a world space position in Unity</para>
    /// <br />
    /// <returns>Vector2 representing the world space position of the square that was clicked</returns>
    private Vector2 GetSquareClicked()
    {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        Vector2 gridPosition = SnapToGrid(worldPosition);
        return gridPosition;
    }

    /// <summary>Snaps the defender to the grid by rounding the world position to the nearest integer</summary>
    /// <br />
    /// <param name= "rawWorldPosition">The world position before rounding</param>
    /// <br />
    /// <returns>A Vector2 representing the new, rounded, world position</returns>
    private Vector2 SnapToGrid(Vector2 rawWorldPosition)
    {
        float newX = Mathf.RoundToInt(rawWorldPosition.x);
        float newY = Mathf.RoundToInt(rawWorldPosition.y);
        return new Vector2(newX, newY);
    }

    /// <summary>Spawns a defender</summary>
    /// <br />
    /// <param name= "roundedPosition">
    /// A Vector2 representing the world space position to spawn the Defender. 
    /// Rounded to the nearest int.
    /// </param>
    private void SpawnDefender(Vector2 roundedPosition)
    {
        Defender newDefender = Instantiate(defender, roundedPosition, Quaternion.identity) as Defender;
        //Debug.Log(roundedPosition);
    }

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class DefenderSpawner

#endregion // CLASS DEFINITION
