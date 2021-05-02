using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject move;
    private RandomMovement speed;
    
    public GameObject restartPanel;
    public GameObject level;
    private LevelLoader _level;
    public Text score;
    float timeLimit = 10f;
    public GameObject congratsPanel;
    // Start is called before the first frame update
    bool hasLost; 
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void startGame()
    {
        _level.loadNextLevel();
      /*  SceneManager.LoadScene("Level1");*//**/
    }
    public void gameOver()
    {
        hasLost = true;
        move.SetActive(false);
        restartPanel.SetActive(true);
      
    }
    
    public void Delay()
    {
        restartPanel.SetActive(true);
    }
    

    public void quit()
    {
        Application.Quit(); 
    }

    public void loadIntructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void levelSelect() { 
    
    SceneManager.LoadScene("LevelSelect");
    
    }
    public void aboutMe()
    {
        SceneManager.LoadScene("AboutME");
    }


    void Start()
    {
        _level = level.GetComponent<LevelLoader>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            if ((hasLost == false) && (timeLimit > Time.timeSinceLevelLoad))
            {
                score.text = (timeLimit - Time.timeSinceLevelLoad).ToString("F0");
            }

            if ((hasLost == false) && (Time.timeSinceLevelLoad > timeLimit))
            {
                /*Time.timeScale = 0;*/
                congratsPanel.SetActive(true);
                move.SetActive(false);
                /*Time.timeScale = 0;*/
            }
        }
 
    }

IEnumerator screen()
    {
        yield return new WaitForSecondsRealtime(2f);
        Time.timeScale = 1;
    
    }

}
