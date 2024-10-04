using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _EnnemyPrefab;

    [SerializeField]
     private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    private float _timeUntilSpawn;

    // Start is called before the first frame update
    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            
                Instantiate(_EnnemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }
     
    private void SetTimeUntilSpawn() 
    {
     _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);

    }
 } 
