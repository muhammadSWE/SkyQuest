﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            
    }
    private void OnEnable()
    {
        simpleControl.canControlCam = true;
    }
    // Update is called once per frame
    void Update()
    {
        //if(this.gameObject.activeSelf)
            //simpleControl.canControlCam = true;
    }
}
