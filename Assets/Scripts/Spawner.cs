using UnityEngine;

namespace PlaneBird
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject spikePrefab;
        [SerializeField] private float spawnRate = 2f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            InvokeRepeating(nameof(SpawnSpike), 0f, spawnRate);
        }

        private void SpawnSpike()
        {
            Instantiate(spikePrefab, transform.position, transform.rotation, transform);
        }
    }
}
