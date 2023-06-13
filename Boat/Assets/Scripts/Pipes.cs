using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
	//variables
	public float speed = 5f ;
	private  float leftEdge;
	
	
    // Start is called before the first frame update
    void Start()
    {
    	leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y -11f;
    }

    // Update is called once per frame
    void Update()
    {
    	transform.position += Vector3.down * speed * Time.deltaTime;
    	if(transform.position.y < leftEdge)
    	{
    		Destroy(gameObject);
    	}
        
    }
}
