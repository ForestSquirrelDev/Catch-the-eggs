using System;
using Game;
using TMPro;
using UnityEngine;

namespace InGameUI {
    public class ScoreCounter : MonoBehaviour {
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private int scorePerEgg = 1;
        [SerializeField] private PlayerEggCatcher eggCatcher;

        private int totalScore;

        private void Awake() {
            scoreText.text = totalScore.ToString();
        }

        private void OnEnable() {
            eggCatcher.CaughtEgg += OnPlayerCaughtEgg;
        }

        private void OnPlayerCaughtEgg() {
            totalScore += scorePerEgg;
            scoreText.text = $"Score: {totalScore.ToString()}";
        }
    }
}