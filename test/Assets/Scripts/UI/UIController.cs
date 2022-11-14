using UnityEngine;

namespace UI
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private LoseScreen _lose;
        [SerializeField] private VictoryScreen _victory;
        public LoseScreen loseScreen => _lose;
        public VictoryScreen victoryScreen => _victory;
    }
}