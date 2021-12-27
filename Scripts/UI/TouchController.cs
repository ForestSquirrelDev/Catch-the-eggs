using Game;
using JetBrains.Annotations;
using UnityEngine;

namespace InGameUI {
    public class TouchController : MonoBehaviour {
        [SerializeField] private PlayerMovement player;

        [UsedImplicitly]
        public void SnapLeft() {
            player.SnapPosition(MovementPointsController.Directions.Left);
        }

        [UsedImplicitly]
        public void SnapRight() {
            player.SnapPosition(MovementPointsController.Directions.Right);
        }
    }
}