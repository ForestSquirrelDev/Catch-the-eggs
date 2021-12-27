using UnityEngine;

namespace Game {
    public class PlayerMovement : MonoBehaviour {
        [SerializeField] private MovementPointsController pointsController;
        
        private void Update() {
            if (Input.GetKeyDown(KeyCode.A)) {
                SnapPosition(MovementPointsController.Directions.Left);
            }
            if (Input.GetKeyDown(KeyCode.D)) {
                SnapPosition(MovementPointsController.Directions.Right);
            }
        }
        
        public void SnapPosition(MovementPointsController.Directions direction) {
            if (Time.deltaTime == 0f) return;
            transform.position = pointsController.Snap(direction);
        }
    }
}