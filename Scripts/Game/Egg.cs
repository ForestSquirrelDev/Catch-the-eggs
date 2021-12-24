using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Game {
    public class Egg : MonoBehaviour {
        [SerializeField] private float fadeTime = 0.2f;

        private void OnTriggerEnter2D(Collider2D other) {
            if (other.TryGetComponent(out PlayerEggCatcher playerEggCatcher)) {
                transform.parent = playerEggCatcher.transform;
                StartCoroutine(CollectEgg());
            }
        }

        private IEnumerator CollectEgg() {
            yield return GetComponent<SpriteRenderer>().DOFade(0f, fadeTime).WaitForCompletion();
            Destroy(gameObject, 0.1f);
        }
    }
}