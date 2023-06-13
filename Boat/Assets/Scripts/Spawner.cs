using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	// variables
	public GameObject prefab;
	public float spawnRate = 1f;
	public float minheight = -3f , maxHeight = 1f;
	
	
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    void OnEnable()
    {
    	InvokeRepeating(nameof(Spawn) , spawnRate , spawnRate);
    }
    
    void OnDisable()
    {
    	CancelInvoke(nameof(Spawn));
    }
    
    void Spawn()
    {
    	GameObject pipes = Instantiate(prefab,transform.position,Quaternion.identity);
    	pipes.transform.position += Vector3.left * Random.Range(minheight , maxHeight);
    }
}
