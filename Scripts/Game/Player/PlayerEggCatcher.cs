using System;
using Game.Eggs;
using UnityEngine;

namespace Game {
    public class PlayerEggCatcher : MonoBehaviour {
        public event Action CaughtEgg;

        private void OnTriggerEnter2D(Collider2D other) {
            if (other.TryGetComponent(out Egg egg)) {
                CaughtEgg?.Invoke();
            }
        }
    }
}