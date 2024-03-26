using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 1; // Maximum health of the player
    private int currentHealth; // Current health of the player
    public Transform respawnPoint; // Respawn point for the player

    void Start()
    {
        currentHealth = maxHealth; // Set current health to maximum health when the game starts
    }

    // Function to take damage
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Decrease current health by the damage amount

        if (currentHealth <= 0)
        {
            Die(); // Call Die() function if health drops to or below 0
        }
    }

    // Function to handle player death
    void Die()
    {
        Debug.Log("Player died!"); // Print a message to the console

        // Reset player's position to the respawn point
        transform.position = respawnPoint.position;

        // Restore player's health to full
        currentHealth = maxHealth;
    }

}
