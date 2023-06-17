using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Levels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void level1()
    {
    	SceneManager.LoadScene(2);
    }
    
    public void level2()
    {
    	SceneManager.LoadScene(3);
    }
    
    public void level3()
    {
    	SceneManager.LoadScene(4);
    }
}
