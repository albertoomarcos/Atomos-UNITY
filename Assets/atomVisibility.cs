using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atomVisibility : MonoBehaviour
{
	public GameObject elemento1;
	public GameObject elemento2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
			elemento1.SetActive (false);
			elemento2.SetActive (false);
        
    }
}
