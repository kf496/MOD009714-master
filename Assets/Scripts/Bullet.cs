using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20f;  // Damage the bullet deals
    public AudioSource audioSource;

    void start()
    {
        audioSource.Play();
    }

    void OnTriggerEnter(Collider collision)
    {
        // Check if the bullet hits the player
        PlayerHP playerHealth = collision.gameObject.GetComponent<PlayerHP>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            Debug.Log("Player Hit");
        }

        // Destroy the bullet after impact
        Destroy(gameObject);
    }
}
