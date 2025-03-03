using Klak.Ndi.Interop;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // The collectable prefab to spawn
    public int numberOfEnemies = 10; // Number of collectables to spawn
    public float minRadius = 40f; // Minimum distance from the center
    public float maxRadius = 100f; // Maximum distance from the center

    public EnemyFollow enemyFollow;

    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 randomPosition = GenerateRandomPosition();
            Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            enemyFollow.speed = Random.Range(4, 8);
        }
    }

    Vector3 GenerateRandomPosition()
    {
        float distance = Random.Range(minRadius, maxRadius);
        float angle = Random.Range(0f, Mathf.PI * 2);
        float height = Random.Range(0, distance);

        // Convert polar coordinates to Cartesian coordinates
        float x = distance * Mathf.Cos(angle);
        float z = distance * Mathf.Sin(angle);
        float y = height - distance / 2;
        // Assuming y = 0 for ground-level placement
        return new Vector3(x, y, z);
    }
}