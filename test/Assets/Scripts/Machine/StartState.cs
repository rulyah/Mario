using UnityEngine;

namespace Machine
{
    public class StartState : State<GameController>
    {
        public StartState(GameController core) : base(core) {}

        public override void OnEnter()
        {
            _core.player.transform.position = _core.level.startPoint.position;
            ChangeState(new SpawnEnemyState(_core));
            // create player
        }
    }
}