using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class Attack : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] public float meleeSpeed =1.0f;
    [SerializeField] public float damage=10;
    float meleeCount =0f;
    public AI ai;

    private void Update()
    {
        // Decrease meleeCount only if it's greater than 0
        if (meleeCount > 0f)
        {
            meleeCount -= Time.deltaTime;
        }

        // Check for attack input and whether the cooldown has finished
        if (Input.GetMouseButtonDown(0) && meleeCount <= 0f)
        {
            anim.SetTrigger("Attack");
            meleeCount = meleeSpeed; // Reset the cooldown
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ai.TakeDamage(damage);
            Debug.Log("Hit");
        }
    }
}
