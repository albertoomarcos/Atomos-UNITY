﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textHidrogenoScript : MonoBehaviour
{
	public GameObject myobject;
	public bool activate = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	if (Input.GetKeyDown(KeyCode.I))
    	{
    		activate = !activate;
    		myobject.SetActive (activate);
    	}
    }
}
