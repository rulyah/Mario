namespace Commands
{
    public static class DestroyEnemyCommand
    {
        public static void Execute(EnemyController enemy, GameController core)
        {
            core.enemyControllers.Remove(enemy);
            enemy.Destroy();
        }
    }
}