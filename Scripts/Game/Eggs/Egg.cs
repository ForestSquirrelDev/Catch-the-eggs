using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Game.Eggs {
    public class Egg : MonoBehaviour {
        [SerializeField] private Ease ease;
        [SerializeField] private float fadeTime = 0.2f;

        private Tween fadeTween;
        
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.TryGetComponent(out PlayerEggCatcher playerEggCatcher)) {
                transform.parent = playerEggCatcher.transform;
                StartCoroutine(CollectEgg());
            }
        }

        private void OnDestroy() {
            fadeTween?.Kill();
        }

        private IEnumerator CollectEgg() {
            fadeTween = GetComponent<SpriteRenderer>().DOFade(0f, fadeTime).SetEase(ease);
            yield return fadeTween.WaitForCompletion();
            Destroy(gameObject, 0.01f);
        }
    }
}