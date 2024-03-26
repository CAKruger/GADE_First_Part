using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreCounter : MonoBehaviour
{
    private int PlayerScore = 0;
    public GameObject PLayerFlag;
    public Scoreboard scoreboard;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Flag"))
        {
            
            PLayerFlag.transform.parent = null;
            scoreboard.pScore++;
            scoreboard.RoundSwitch();
        }
        
    }
   
}