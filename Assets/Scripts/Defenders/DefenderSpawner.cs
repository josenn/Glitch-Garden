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

    [SerializeField] private Defender defender;

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

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        Vector2 gridPosition = SnapToGrid(worldPosition);
        return gridPosition;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPosition)
    {
        float newX = Mathf.RoundToInt(rawWorldPosition.x);
        float newY = Mathf.RoundToInt(rawWorldPosition.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedPosition)
    {
        GameObject newDefender = Instantiate(defender, roundedPosition, Quaternion.identity) as GameObject;
        Debug.Log(roundedPosition);
    }

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class Template

#endregion // CLASS DEFINITION
