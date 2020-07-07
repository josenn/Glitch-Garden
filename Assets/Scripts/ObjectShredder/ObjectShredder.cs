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
**      Module:              ObjectShredder                      **
**                                                               **
**      File name:           ObjectShredder.cs                   **
**                                                               **
**      Created by:          06/17/20            - JJR           **
**                                                               **
**      Description:         Destroys excess game objects        **
**                           once they have left the play area   **
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

#region OBJECTSHREDDER CLASS DEFINITION
/// <summary>Base class for Object Shredders</summary>
public class ObjectShredder : MonoBehaviour
{
    #region UNITY FUNCTIONS

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

    #endregion // UNITY FUNCTIONS

} // Class ObjectShredder

#endregion // CLASS DEFINITION
