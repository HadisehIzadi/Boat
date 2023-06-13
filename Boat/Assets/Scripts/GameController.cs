using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameController : MonoBehaviour
{
    private int Score;
	public TextMeshProUGUI Scoring;
	public GameObject gameOver;
	public GameObject playButton;
	public GameObject waveGenerator;
	public Boat player;
    // Start is called before the first frame update
    public void Start()
    {
        
    }
    /*
    public void Awake()
    {
    	Application.targetFrameRate = 60;
    	pause();
    }
    */
    
    public void pause()
    {
    	Time.timeScale = 0f;
    	player.enabled = false;
    }
    
    
    public void IncreaseScore()
    {
    	Score++;
    	Scoring.text = Score.ToString();
    	
    }
    public void checkButton()
    {
    	gameOver.SetActive(true);
    }
    
    
   public void Play()
    {
    	Score = 0 ;
    	//Scoring.text = Score.ToString();
    	
    	playButton.SetActive(false);
    	gameOver.SetActive(false);
    	waveGenerator.SetActive(true);
    	Time.timeScale = 1f;
    	player.enabled = true;
    	player.transform.position = new Vector3(0f , 0f ,0f);
    	
    	Pipes[] pipes = FindObjectsOfType<Pipes>();
    	
    	for(int i = 0 ; i < pipes.Length ; i++)
    	{
    		Destroy(pipes[i].gameObject);
    	}
    }
    
    
    public void GameOver()
    {
    	waveGenerator.SetActive(false);
    	gameOver.SetActive(true);
    	playButton.SetActive(true);
    	Scoring.text = Score.ToString();
    	Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
