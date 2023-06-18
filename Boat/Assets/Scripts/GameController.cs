using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
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
    	waveGenerator.SetActive(true);
    	playButton.SetActive(false);
    	gameOver.SetActive(false);
    	//Time.timeScale = 1f;
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    	
    	
    	
    }
    
    
    public void GameOver()
    {
    	waveGenerator.SetActive(false);
    	gameOver.SetActive(true);
    	playButton.SetActive(true);
    	Scoring.text = Score.ToString();
    	//Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void StartGame()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Home()
    {
    	SceneManager.LoadScene(0);
    }
}
