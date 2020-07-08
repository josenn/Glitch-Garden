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
/// <summary>Base class for the Defender Buttons that a player can select</summary>
public class DefenderButton : MonoBehaviour
{
	#region PRIVATE VARIABLES

    private Color buttonColor;

    [SerializeField] Defender defenderPrefab = null;
    private Text starCostText;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
        starCostText = GetComponentInChildren<Text>();

        if(starCostText)
        {
            UpdateButtonCost();
        }
        else
        {
            Debug.LogError("No text component found on: " + gameObject.name);
        }
        
        buttonColor = Color.white;
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    private void OnMouseDown()
    {
        if(FindObjectOfType<DefenderSpawner>().GetIsGameOver())
        {
            return;
        }

        var buttons = FindObjectsOfType<DefenderButton>(); // Look for all of the defender buttons

        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<Image>().color = new Color32(43, 43, 43, 255);
        }
        
        gameObject.GetComponent<Image>().color = buttonColor;

        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }

    #endregion // UNITY FUNCTIONS

	#region PRIVATE FUNCTIONS

    /// <summary>Updates the text component for the cost of each button</summary>
    private void UpdateButtonCost()
    {
        starCostText.text = defenderPrefab.GetStarCost().ToString();
    }

	#endregion // PRIVATE FUNCTIONS

} // Class DefenderButton

#endregion // CLASS DEFINITION
