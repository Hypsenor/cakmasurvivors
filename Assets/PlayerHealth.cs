using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
        currentHealth = maxHealth;
    }

    public void UpdateHealth()
    {
        healthBar.SetMaxHealth(maxHealth);
        currentHealth = maxHealth;
    }
     public void TakeDamage()
    {
        currentHealth--;
        healthBar.SetHealth(currentHealth);
    }
}


