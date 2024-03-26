using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Scoreboard : MonoBehaviour
{
        public int pScore;
        public int enemyScore;
        public int round;
        public GameObject Player;
        public GameObject AI;
        public GameObject enemyFlag;
        public GameObject playerFlag;
        public TextMeshProUGUI blueScoreText;
        public TextMeshProUGUI redScoreText;
        public TextMeshProUGUI gameOverText;
        public bool restart = false;
        public aiFlag aiFlag;
        public Flag pFlag;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R) && restart == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1;
                restart = false;
            }
        }

        public void RoundSwitch()
        {
            round++;
            Player.transform.position = new Vector3(-4f, 0, 0);
            AI.transform.position = new Vector3(4f, 0, 0);
            enemyFlag.transform.parent = null;
            playerFlag.transform.parent = null;
            enemyFlag.transform.position = new Vector3(7.55f, 0, 0);
            playerFlag.transform.position = new Vector3(-7.55f, 0, 0);
            aiFlag.aiflag = false;
            pFlag.playerflag = false;
            pFlag.pDrop = false;
            if ( pScore == 10 || enemyScore==10)
            {
                Time.timeScale = 0;
                if (pScore > enemyScore)
                {
                    gameOverText.text = "Player Wins press R to restart";
                    restart = true;
                }
                else
                {
                    restart = true; ;
                    gameOverText.text = "Enemy Wins press R to restart";
                }
            }
        }
        public void Scoring()
        {
            blueScoreText.text = "Score: " + pScore;
            redScoreText.text = "Score: " + enemyScore;
        }
}
