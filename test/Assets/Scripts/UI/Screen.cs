using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class Screen : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private CanvasGroup _canvas;

        public virtual void Show()
        {
            _button.onClick.AddListener(OnButtonClick);
            _canvas.alpha = 1.0f;
            _canvas.interactable = true;
            _canvas.blocksRaycasts = true;
        }

        private void OnButtonClick()
        {
            Hide();
        }

        public virtual void Hide()
        {
            _button.onClick.RemoveListener(OnButtonClick);
            _canvas.alpha = 0.0f;
            _canvas.interactable = false;
            _canvas.blocksRaycasts = false;
        }
    }
}