namespace Machine
{
    public class VictoryState : State<GameController>
    {
        public VictoryState(GameController core) : base(core) {}

        public override void OnEnter()
        {
            _core.uiController.victoryScreen.Show();
        }
    }
}