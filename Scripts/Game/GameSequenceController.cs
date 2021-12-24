using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game {
    public class GameSequenceController : MonoBehaviour {
        [SerializeField] private GroundController ground;

        private void OnEnable() {
            ground.EggFellDown += OnEggFellDown;
        }

        public void RestartGame() {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        private void OnEggFellDown() {
            Time.timeScale = 0f;
        }
    }
}