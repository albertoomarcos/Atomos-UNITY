using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generico : MonoBehaviour
{
    	public GameObject elemento1;
	public GameObject elemento2;
	public GameObject molecula;
	private float dist;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {	
    	dist = Vector3.Distance(elemento1.transform.position, elemento2.transform.position);

		if(dist < 8f)
		{
			elemento1.SetActive (false);
			elemento2.SetActive (false);
			molecula.SetActive (true);
		}
		else
		{
			elemento1.SetActive (true);
			elemento2.SetActive (true);
			molecula.SetActive (false);
		}	
    }
}