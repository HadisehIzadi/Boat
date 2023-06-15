using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public int MaxReflectCount = 1;
    public float Speed = 1f;
    

    private int _reflectCount = 0;
    
    private void Update()
    {
        transform.position += transform.up * (Speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if (collision.contacts[0].collider.gameObject.GetComponent<zom>())
        var contactNormal = collision.contacts[0].normal;
        transform.up = Vector2.Reflect(transform.up, contactNormal);
        _reflectCount++;
        if (_reflectCount > MaxReflectCount)
        {
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
    	if (other.gameObject.CompareTag("Player")) {
    		Destroy(gameObject);
    		
    	}
    }
    
    
}
