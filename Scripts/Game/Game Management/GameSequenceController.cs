using Game.Environment;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.GameManagement {
    public class GameSequenceController : MonoBehaviour {
        [SerializeField] private GroundController ground;

        private void OnEnable() {
            ground.EggFellDown += OnEggFellDown;
        }

        private void OnDestroy() {
            ground.EggFellDown -= OnEggFellDown;
        }

        public void RestartGame() {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            Time.timeScale = 1f;
        }

        private void OnEggFellDown() {
            Time.timeScale = 0f;
        }
    }
}