using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textVisibility : MonoBehaviour
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
		if (Input.touchCount > 0)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Ended)
        	{
				activate = !activate;
				myobject.SetActive (activate);
			}
		}
    }
}
