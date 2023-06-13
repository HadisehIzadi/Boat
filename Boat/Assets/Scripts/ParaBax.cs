using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaBax : MonoBehaviour
{
	
	//vaiables
	private MeshRenderer meshRenderer;
	public float animSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
    	meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    	meshRenderer.material.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime , 0);
    }
}
