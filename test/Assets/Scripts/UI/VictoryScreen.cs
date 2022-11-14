
using TMPro;
using UnityEngine;

namespace UI
{
    public class VictoryScreen : Screen
    {
        [SerializeField] private TextMeshProUGUI _text;

        public override void Show()
        {
            base.Show();
            _text.text = "Victory";
        }
    }
}