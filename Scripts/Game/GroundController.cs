using System;
using UnityEngine;

namespace Game {
    public class GroundController : MonoBehaviour {
        public event Action EggFellDown;
        
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.TryGetComponent(out Egg egg)) {
                EggFellDown?.Invoke();
            }
        }
    }
}