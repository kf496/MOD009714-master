using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;               // Reference to the player's transform
    public float speed = 5f;               // Enemy movement speed
    public float rotationSpeed = 2f;       // Rotation speed toward the player
    public GameObject bulletPrefab;        // Prefab for the bullet
    public Transform firePoint;            // Position where bullets spawn
    public float bulletSpeed = 10f;        // Speed of the bullet
    public float fireRate = 1.5f;          // Time between shots

    private float fireCooldown = 0f;

    void Update()
    {
        if (player != null)
        {
            // Move towards the player
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            // Rotate smoothly towards the player
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

            // Handle shooting
            fireCooldown -= Time.deltaTime;
            if (fireCooldown <= 0f)
            {
                ShootAtPlayer();
                fireCooldown = fireRate;
            }
        }
    }

    void ShootAtPlayer()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            // Instantiate bullet at the fire point
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            // Add velocity to the bullet
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = firePoint.forward * bulletSpeed;
            }

            // Set bullet damage if Bullet script exists
            Bullet bulletScript = bullet.GetComponent<Bullet>();
            if (bulletScript != null)
            {
                bulletScript.damage = 20f; // Set damage value here
            }

            // Destroy bullet after 5 seconds to avoid clutter
            Destroy(bullet, 5f);
        }
    }
}
