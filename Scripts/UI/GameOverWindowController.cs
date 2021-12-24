using Game;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace InGameUI {
    public class GameOverWindowController : MonoBehaviour {
        [SerializeField] private Image background;
        [SerializeField] private Image popupWindow;
        [SerializeField] private GroundController ground;
        [SerializeField] private GameSequenceController sequenceController;

        private void OnEnable() {
            ground.EggFellDown += OnEggFellDown;
        }

        private void OnEggFellDown() {
            background.gameObject.SetActive(true);
            popupWindow.gameObject.SetActive(true);
        }
        
        [UsedImplicitly]
        public void Restart() => sequenceController.RestartGame();
    }
}