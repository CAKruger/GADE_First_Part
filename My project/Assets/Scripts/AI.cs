using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
   public Flag pFlag;
   public NavMeshAgent agent;
    public GameObject enemyFlag;
    public GameObject aiBase;
    public GameObject playerFlag;
    public GameObject player;
    [SerializeField] private float health;
    public aiFlag flag;
    float meleeCount;
    [SerializeField] private Animator anim;
    [SerializeField] public float meleeSpeed;
    public GameObject HomeBase;
    public enum AiState
    { 
        GetFlag,
        Score,
        returnFlag,
        Attacking
        
    }

    private AiState currentState;

    void Start()
    {
        SetState(AiState.GetFlag);
    }

    void Update()
    {

        this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
       
        
         if (pFlag.playerflag == true)
            {
                SetState(AiState.Attacking);

         }
       
        else if (pFlag.pDrop==true)
        {
            SetState(AiState.returnFlag);
        }
        else if (flag.aiflag==true)
        {
            SetState(AiState.Score);
        }
        else
        {
            SetState(AiState.GetFlag);
        }

        PerformStateBehavior();
    }

    // Method to set the current state
    private void SetState(AiState newState)
    {
        currentState = newState;
        // Perform any additional actions when entering a new state
        EnterState();
    }

    // Method to handle state-specific behavior
    private void PerformStateBehavior()
    {
        // Implement behavior specific to each state
        switch (currentState)
        {
            case AiState.Score:
                agent.destination= aiBase.transform.position;
                break;
            case AiState.GetFlag:
                agent.destination = enemyFlag.transform.position;
                break;
            case AiState.returnFlag:
                agent.destination = playerFlag.transform.position;
                break;
            case AiState.Attacking:
                agent.destination = player.transform.position;
                anim.SetTrigger("Attack");
                meleeCount = meleeSpeed;

                break;
                // Add more cases for additional states
        }
    }

    // Method to handle actions when entering a new state
    private void EnterState()
    {
        // Implement any actions needed when entering a new state
        Debug.Log("Entering State: " + currentState);
    }
    public void TakeDamage(float damage)
    {
        health-=damage;

        if (health <= 0f)
        {
           this.transform.position= new Vector3 (6.93f, 0,0);
        }
    }


}
