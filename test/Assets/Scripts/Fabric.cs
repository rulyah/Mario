using UnityEngine;

public class Fabric : MonoBehaviour
{
    [SerializeField] private EnemyController _enemyPrefab;
    
    public EnemyController CreateEnemy()
    {
        return Instantiate(_enemyPrefab);
    }
}