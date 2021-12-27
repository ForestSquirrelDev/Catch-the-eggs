using System.Collections.Generic;
using UnityEngine;

namespace Game {
    public class MovementPointsController : MonoBehaviour {
        [SerializeField] private float yPos = -2.95f;
        [SerializeField] private List<Transform> points = new();

        private int currentPoint;

        public Vector3 Snap(Directions directions) {
            currentPoint = directions switch {
                Directions.Left => currentPoint - 1,
                Directions.Right => currentPoint + 1,
                _ => currentPoint
            };
            currentPoint = Mathf.Clamp(currentPoint, 0, points.Count - 1);
            Vector3 newPoint = points[currentPoint].position;
            newPoint.y = yPos;
            return newPoint;
        }

        public enum Directions {
            Left,
            Right
        }
    }
}