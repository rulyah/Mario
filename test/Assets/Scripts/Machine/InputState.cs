using System.Collections;
using Commands;
using UnityEngine;

namespace Machine
{
    public class InputState : State<GameController>
    {
        public InputState(GameController core) : base(core) {}
        private Coroutine _coroutine;
        
        public override void OnEnter()
        {
            for (var i = 0; i < _core.enemyControllers.Count; i++)
            {
                _core.enemyControllers[i].onUpperCollision += OnUpperEnemyCollision;
                _core.enemyControllers[i].onCollision += OnEnemyCollision;
            }
            _coroutine = _core.StartCoroutine(CheckIsLive());
            _core.level.finishLvlPlace.onFinishPlaceEnter += OnFinishPlaceEnter;
            _core.input.onJumpClick += OnJumpClick;
            _core.input.onLeftClick += OnLeftClick;
            _core.input.onRightClick += OnRightClick;
            _core.input.onStopMove += OnStopMove;
        }

        private void OnEnemyCollision(EnemyController enemyController, ICollidable obj)
        {
            if(obj is Player player) player.TakeDamage(); 
            DestroyEnemyCommand.Execute(enemyController,_core);
        }

        private void OnStopMove()
        {
            _core.player.Move(0.0f);
        }

        private void OnRightClick()
        {
            _core.player.Move(5.0f);
        }

        private void OnLeftClick()
        {
            _core.player.Move(-5.0f);
        }

        private void OnJumpClick()
        {
            _core.player.Jump();
        }

        private void OnUpperEnemyCollision(EnemyController enemyController, ICollidable obj)
        {
            DestroyEnemyCommand.Execute(enemyController, _core);
        }

        private void OnFinishPlaceEnter()
        {
            ChangeState(new VictoryState(_core));
        }

        public override void OnExit()
        {
            for (var i = 0; i < _core.enemyControllers.Count; i++)
            {
                _core.enemyControllers[i].onUpperCollision -= OnUpperEnemyCollision;
            }
            _core.StopCoroutine(_coroutine);
            _core.level.finishLvlPlace.onFinishPlaceEnter += OnFinishPlaceEnter;
            _core.input.onJumpClick += OnJumpClick;
            _core.input.onLeftClick += OnLeftClick;
            _core.input.onRightClick += OnRightClick;
            _core.input.onStopMove += OnStopMove;
        }

        private IEnumerator CheckIsLive()
        {
            while (true)
            {
                if(!_core.player.isLive) ChangeState(new LoseState(_core));
                yield return new WaitForEndOfFrame();
            }
        }
    }
}