namespace Machine
{
    public class SpawnEnemyState : State<GameController>
    {
        public SpawnEnemyState(GameController core) : base(core) {}

        public override void OnEnter()
        {
            for (var i = 0; i < _core.enemySpawner.spawnPointCount; i++)
            {
                var enemy = _core.fabric.CreateEnemy();
                _core.enemySpawner.SpawnEnemy(enemy);
                enemy.SetTarget(_core.player); 
                _core.enemyControllers.Add(enemy);
            }
            ChangeState(new InputState(_core));
        }
    }
}