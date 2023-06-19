using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Boat : MonoBehaviour
{
	public float magnitude = 200f ;
	public int maxHelth;
	public GameObject[] boatHelth;
    // Start is called before the first frame update
    void Start()
    {
    	maxHelth = 3;
    }

    // Update is called once per frame
    void Update()
    {
    	if(maxHelth <= 0 )
    		 FindObjectOfType<GameController>().GameOver();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
    	
        
    	if (other.gameObject.CompareTag("Wave")) {
    		        //transform.position = new Vector3(Mathf.PingPong(Time.time * 10000, 5), transform.position.y, transform.position.z);
    		       // transform.Translate(new Vector2(0 , 35*Time.deltaTime));
    		  

    		var force = transform.position - other.transform.position ;
   			 force.Normalize();
   			 gameObject.GetComponent<Rigidbody2D>().AddForce(force * magnitude * Time.deltaTime);

    	}
}

    	
    
    
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstracle")
        {
            
    		Debug.Log("hit");
    		maxHelth--;
    		Debug.Log(maxHelth);
    		boatHelth[maxHelth].SetActive(false);
        }
        
        if (collision.gameObject.tag == "Island")
        {
            
    		Debug.Log("win");
    		FindObjectOfType<GameController>().Win();
    		
        }
    }
}
