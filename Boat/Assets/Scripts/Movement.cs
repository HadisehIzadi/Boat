using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 9f;

    void Start()
    {
    	
    }

    void Update()
    {

    	MovePlayer();
    }
    
    void MovePlayer()
    {
    	// if ( Input.GetKeyDown(KeyKode.A))
    	// ....

    	float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    	float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    	
    	transform.Translate(x,0,z);
    }
}
