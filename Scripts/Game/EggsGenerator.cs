using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game {
    public class EggsGenerator : MonoBehaviour {
        [SerializeField] private PlayerEggCatcher eggCatcher;
        [SerializeField] private Vector2 spawnRange = Vector2.one;
        [SerializeField] private List<Transform> spawnPoints = new();
        [SerializeField] GameObject eggPrefab;

        private float counter;

        private void OnEnable() {
            eggCatcher.CaughtEgg += OnCaughtEgg;
        }
        
        private void Start() {
            SetRandomSpawnTime();
        }
        
        private void Update() {
            counter -= Time.deltaTime;
            if (counter <= 0) {
                SpawnEgg();
                SetRandomSpawnTime();
            }
        }
        
        private void OnCaughtEgg() {
            spawnRange.y = Mathf.Clamp(spawnRange.y -= Time.deltaTime, spawnRange.x, float.MaxValue);
        }
        
        private void SetRandomSpawnTime() {
            counter = Random.Range(spawnRange.x, spawnRange.y);
        }

        private void SpawnEgg() {
            int index = Random.Range(0, spawnPoints.Count);
            Instantiate(eggPrefab, spawnPoints[index].position, Quaternion.identity);
        }
    }
}