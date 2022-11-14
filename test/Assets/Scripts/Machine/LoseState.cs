namespace Machine
{
    public class LoseState : State<GameController>
    {
        public LoseState(GameController core) : base(core) {}

        public override void OnEnter()
        {
            _core.uiController.loseScreen.Show();
        }
    }
}