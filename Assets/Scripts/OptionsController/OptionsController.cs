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
**      Module:              OptionsController                   **
**                                                               **
**      File name:           OptionsController.cs                **
**                                                               **
**      Created by:          06/24/20            - JJR           **
**                                                               **
**      Description:         Controls the in game options        **
**                                                               **
**      There are currently only options for difficulty          **
**      and volume but I may add more in the future              **
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

#region OPTIONS_CONTROLLER CLASS DEFINITION
/// <summary>Base class for the Options Controller</summary>
public class OptionsController : MonoBehaviour
{
	#region PRIVATE VARIABLES

    private MusicPlayer musicPlayer;

    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Slider difficultySlider = null;
    private float DEFAULT_VOLUME = 0.5f;
    private float DEFAULT_DIFFICULTY = 1.0f;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Awake()
    {
        difficultySlider.minValue = 0.0f;
        difficultySlider.maxValue = 2.0f;
    }

    private void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
        musicPlayer = FindObjectOfType<MusicPlayer>();
    }

    private void Update()
    {
        UpdateVolume();
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    /// <summary>Sets each option back to its default value</summary>
    public void SetToDefaultValues()
    {
        volumeSlider.value = DEFAULT_VOLUME;
        difficultySlider.value = DEFAULT_DIFFICULTY;
    }

    /// <summary>Saves the volume the player set and goes back to the start menu</summary>
    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().LoadStartScene();
    }

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

    /// <summary>Updates the game's volume</summary>
    private void UpdateVolume()
    {
        if(!musicPlayer)
        {
            Debug.LogWarning("No Music Player found... did you forget to start from the SplashScreen?");
            return;
        }

        musicPlayer.SetVolume(volumeSlider.value);
    }

	#endregion // PRIVATE FUNCTIONS

} // Class OptionsController

#endregion // CLASS DEFINITION
