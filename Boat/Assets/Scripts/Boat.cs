using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstracle")) {
            FindObjectOfType<GameController>().GameOver();
        }
    	else if (other.gameObject.CompareTag("Scoring")) {
            FindObjectOfType<GameController>().IncreaseScore();
        }
    }
}
