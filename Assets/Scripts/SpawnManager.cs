using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;
    public PlayerController player;

    void Start()
    {
        InvokeRepeating("Spawn", 0 , 2.0f);
    }

    void Spawn()
    {
        // or !player.isGameOver
        if (player.isGameOver == false) 
        {
            Instantiate(
                obstaclePrefab,
                spawnPoint.position,
                obstaclePrefab.transform.rotation
            );
        }
    }
}
