using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public HealthBar healthBar;

    public GameOver gameOverScreen;
    private bool isDead;
    public CrashAudio crashAudio;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Player Health: " + currentHealth);
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0 && !isDead)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        gameOverScreen.gameOver();
        Debug.Log("Player Died!");
        // Add death effects or game over logic here
        Destroy(gameObject); // For now, destroy the player on death
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace)) 
        {
            TakeDamage(20);
        }
    }
}
