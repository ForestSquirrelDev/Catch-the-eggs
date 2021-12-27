using System;
using Game.Eggs;
using UnityEngine;

namespace Game.Environment {
    public class GroundController : MonoBehaviour {
        public event Action EggFellDown;
        
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.TryGetComponent(out Egg egg)) {
                EggFellDown?.Invoke();
            }
        }
    }
}