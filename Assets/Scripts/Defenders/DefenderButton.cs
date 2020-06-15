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
**      Module:              Defenders                           **
**                                                               **
**      File name:           DefenderButton.cs                   **
**                                                               **
**      Created by:          06/08/20            - JJR           **
**                                                               **
**      Description:         Controls buttons for defenders      **
**                                                               **
**      This class controls functionality for the defender       **
**      selection buttons in the game                            **
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
using UnityEngine.UI;

#endregion // USING DIRECTIVES


#region DEFENDERBUTTON CLASS DEFINITION
public class DefenderButton : MonoBehaviour
{
    #region PUBLIC VARIABLES

    #endregion // PUBLIC VARIABLES

	#region PRIVATE VARIABLES

    private Color buttonColor;

    [SerializeField] Defender defenderPrefab = null;


    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
        buttonColor = Color.white;
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>(); // Look for all of the defender buttons

        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<Image>().color = new Color32(43, 43, 43, 255);
        }
        //Debug.Log("You have selected a defender!!");
        gameObject.GetComponent<Image>().color = buttonColor;

        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class DefenderButton

#endregion // CLASS DEFINITION
