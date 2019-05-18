using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusion : MonoBehaviour
{
	public GameObject elemento1;
	public GameObject elemento2;
	public GameObject molecula;
	private float dist;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {	
    	dist = Vector3.Distance(elemento1.transform.position, elemento2.transform.position);

		if(dist < 8f)
		{
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
