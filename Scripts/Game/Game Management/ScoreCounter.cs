using System;
using UnityEngine;

namespace Game.GameManagement {
    public class ScoreCounter : MonoBehaviour {
        public event Action<int> ScoreChanged;
        
        [SerializeField] private int scorePerEgg = 1;
        [SerializeField] private PlayerEggCatcher eggCatcher;

        private int totalScore;

        private void OnEnable() {
            eggCatcher.CaughtEgg += OnPlayerCaughtEgg;
        }

        private void OnDestroy() {
            eggCatcher.CaughtEgg -= OnPlayerCaughtEgg;
        }

        private void OnPlayerCaughtEgg() {
            totalScore += scorePerEgg;
            ScoreChanged?.Invoke(totalScore);
        }
    }
}