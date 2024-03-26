using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiScoreing : MonoBehaviour
{
    public GameObject EnemyFlag;
    public Scoreboard scoreboard;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyFlag"))
        {
            EnemyFlag.transform.parent = null;
            scoreboard.enemyScore++;
            scoreboard.RoundSwitch();
        }

    }
}
