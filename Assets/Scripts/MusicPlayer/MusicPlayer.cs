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
**      Module:              MusicPlayer                         **
**                                                               **
**      File name:           MusicPlayer.cs                      **
**                                                               **
**      Created by:          06/24/20            - JJR           **
**                                                               **
**      Description:         Controls playing music              **
**                                                               **
**      The music in question is things like background music    **
**      level themes etc etc                                     **
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
using UnityEngine.SceneManagement;

#endregion // USING DIRECTIVES


#region MUSICPLAYER CLASS DEFINITION
// TODO - UNIMPLEMENTED
public class MusicPlayer : MonoBehaviour
{
    #region PUBLIC VARIABLES

    #endregion // PUBLIC VARIABLES

	#region PRIVATE VARIABLES

    //[SerializeField] private AudioClip[] audioClips = null;
    private AudioSource audioSource;
    //private int currentSceneIndex;
    //private bool hasPlayedAlready;

    #endregion // PRIVATE VARIABLES

    #region UNITY FUNCTIONS

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
        //hasPlayedAlready = false;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        //currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        //HandleWhichMusicShouldPlay(currentSceneIndex);
    }

    #endregion // UNITY FUNCTIONS

    #region PUBLIC FUNCTIONS

    /// <summary>Sets the music player's volume</summary>
    /// <br />
    /// <param name="volume">A float representing the volume to be set</param>
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    #endregion // PUBLIC FUNCTIONS

	#region PRIVATE FUNCTIONS

    /// <summary></summary>
    /*private void HandleWhichMusicShouldPlay(int sceneIndex)
    {
        if(hasPlayedAlready)
        {
            return;
        }

        switch(sceneIndex)
        {
            case 0: // SplashScreen
                audioSource.PlayOneShot(audioClips[0]);
            break;
            
            case 1: // StartMenu
                hasPlayedAlready = false;
                audioSource.PlayOneShot(audioClips[1]);
                audioSource.loop = true;
            break;

            case 2: // OptionsScreen
                audioSource.PlayOneShot(audioClips[2]);
                audioSource.loop = true;
            break;
            
            case 3: // Level01
                audioSource.PlayOneShot(audioClips[3]);
            break;
            default:
                Debug.LogError("There is no scene with that build index.");
            break;
        }
    }*/

	#endregion // PRIVATE FUNCTIONS

	#region TODOS

	#endregion // TODOS

} // Class MusicPlayer

#endregion // CLASS DEFINITION
