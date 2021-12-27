using Game.GameManagement;
using TMPro;
using UnityEngine;

namespace InGameUI {
    public class ScoreCounterUI : MonoBehaviour {
        [SerializeField] private ScoreCounter counter;
        [SerializeField] private TMP_Text scoreText;
        
        private void Awake() {
            SetScoreText(0);
        }
        
        private void OnEnable() {
            counter.ScoreChanged += OnScoreChanged;
        }

        private void OnDestroy() {
            counter.ScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged(int newValue) {
            SetScoreText(newValue);
        }
        
        private void SetScoreText(int value) {
            scoreText.text = $"Score: {value.ToString()}";
        }
    }
}