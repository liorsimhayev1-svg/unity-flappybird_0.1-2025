using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Player player;
    private int score;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;

    public GameObject getReady;

    private void Awake()
    {
        playButton.SetActive(true);
        getReady.SetActive(true);
        gameOver.SetActive(false);

        Application.targetFrameRate = 60;
        Pause();

    }

    public void play()
    {
        score = 0;
        scoreText.text = score.ToString();

        
        playButton.SetActive(false);
        gameOver.SetActive(false);
        getReady.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        // Pipes[] pipes = FindObjectsOfType<Pipes>();

    
        // for (int i = 0; i < pipes.Length; i++)
        // {
        //     Destroy(pipes[i].gameObject);
        // }
        
         MushPipe[] mushpipe = FindObjectsOfType<MushPipe>();

        for (int i = 0; i < mushpipe.Length; i++)
        {
            Destroy(mushpipe[i].gameObject);
        }
     }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

}
