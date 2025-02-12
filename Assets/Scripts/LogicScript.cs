using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public Text scoreFinal;

    public GameObject gameoverscreen;

    public GameObject gameMenu;

    [ContextMenu("Increase Score")]

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
        quitGame();
    }
        else if(Input.GetKeyDown(KeyCode.Tab)){
            pauseGame();
        }
        }
        
    public void addScore(int scoreToAdd)
    {
        playerScore=playerScore+scoreToAdd;
        scoreText.text=playerScore.ToString();
        scoreFinal.text=playerScore.ToString();
    }

    public void restartGame(){
        Time.timeScale=1;
        SceneManager.LoadScene(1);
    }

    public void quitGame(){
        Time.timeScale=1;
        SceneManager.LoadScene(0);
    }

    public void gameOver(){
        gameoverscreen.SetActive(true);
    }

    public void pauseGame(){
        Time.timeScale=0;
        gameMenu.SetActive(true);
    }

    public void resumeGame(){
        Time.timeScale=1;
        gameMenu.SetActive(false);
    }
}
