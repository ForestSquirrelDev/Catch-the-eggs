using Game;
using JetBrains.Annotations;
using UnityEngine;

namespace InGameUI {
    public class TouchController : MonoBehaviour {
        [SerializeField] private MovementPointsController pointsController;
        [SerializeField] private PlayerMovement player;

        [UsedImplicitly]
        public void SnapLeft() {
            pointsController.Snap(MovementPointsController.Directions.Left, out Vector3 position);
            player.transform.position = position;
        }

        [UsedImplicitly]
        public void SnapRight() {
            pointsController.Snap(MovementPointsController.Directions.Right, out Vector3 position);
            player.transform.position = position;
        }
    }
}