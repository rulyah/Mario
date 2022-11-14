using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints;
    private int _gameObjectCount;

    public int spawnPointCount => _spawnPoints.Count;

    public void SpawnEnemy(EnemyController enemy)
    {
        enemy.transform.position = GetSpawnPos();
        _gameObjectCount++;
    }

    private Vector3 GetSpawnPos()
    {
        if (_gameObjectCount > _spawnPoints.Count - 1)
        {
            _gameObjectCount = 0;
        }
        return _spawnPoints[_gameObjectCount].position;
    }
    
}
