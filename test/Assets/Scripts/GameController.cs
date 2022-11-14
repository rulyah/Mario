using System.Collections.Generic;
using Machine;
using UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player _player;
    public Player player => _player;
    [SerializeField] private EnemySpawner _enemySpawner;
    public EnemySpawner enemySpawner => _enemySpawner;
    [SerializeField] private Fabric _fabric;
    public Fabric fabric => _fabric;
    [SerializeField] private Level _level;
    public Level level => _level;
    [SerializeField] private InputController _input;
    public InputController input => _input;
    [SerializeField] private UIController _ui;
    public UIController uiController => _ui;
    
    private StateMachine<GameController> _stateMachine;

    public List<EnemyController> enemyControllers { get; private set; }
    private void Start()
    {
        enemyControllers = new List<EnemyController>(enemySpawner.spawnPointCount);
        _stateMachine = new StateMachine<GameController>(new StartState(this));
    }

}