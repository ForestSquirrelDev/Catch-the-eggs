using UnityEngine;

namespace Game {
    public class PlayerMovement : MonoBehaviour {
        [SerializeField] private MovementPointsController pointsController;
        
        private void Update() {
            if (Input.GetKeyDown(KeyCode.A)) {
                TrySnapPosition(MovementPointsController.Directions.Left);
            }
            if (Input.GetKeyDown(KeyCode.D)) {
                TrySnapPosition(MovementPointsController.Directions.Right);
            }
        }
        private void TrySnapPosition(MovementPointsController.Directions direction) {
            if (pointsController.Snap(direction, out Vector3 newPosition)) {
                transform.position = newPosition;
            }
        }
    }
}