using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game {
    public class MovementPointsController : MonoBehaviour {
        public List<Transform> Points => points;
        
        [SerializeField] private float yPos = -2.95f;
        [SerializeField] private List<Transform> points = new();

        private int currentPoint;

        public bool Snap(Directions directions, out Vector3 newPosition) {
            currentPoint = directions switch {
                Directions.Left => currentPoint - 1,
                Directions.Right => currentPoint + 1,
                _ => currentPoint
            };
            currentPoint = Mathf.Clamp(currentPoint, 0, points.Count - 1);
            if (currentPoint > 0 || currentPoint < points.Count) {
                newPosition = points[currentPoint].position;
                newPosition.y = yPos;
                return true;
            }
            else {
                newPosition = Vector3.zero;
                return false;
            }
        }

        public enum Directions {
            Left,
            Right
        }
    }
}