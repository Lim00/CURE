using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public Vector3 spawnAnchor;

    public float InstantiationTimerSet = 5f;
    private float InstantiationTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        spawnAnchor = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Periodic spawnning of enemy

        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            GameObject.Instantiate(enemy1, spawnAnchor, Quaternion.identity);

            InstantiationTimer = InstantiationTimerSet;
        }
    }
}
