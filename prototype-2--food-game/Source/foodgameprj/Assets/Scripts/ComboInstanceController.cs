﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboInstanceController : MonoBehaviour
{
    public ComboItemConfig config;

    // when player eats the combo item
    public virtual void OnConsume()
    {
        Debug.Log("PARENT CLASS ON CONSUME");
        
    }
}
