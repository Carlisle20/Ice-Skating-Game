using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public GameObject Spawner_1;
    public GameObject Spawner_2;
    public int Score;

    public Text ScoreText;
    
	// Update is called once per frame
	void Update () {
        ScoreText.text = "Score: " + Score;
    }


    public void AddScore()
    {
        Score++;
    }

    public void AddScoreAir()
    {
        Score = Score + 3;
    }

    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }
}
