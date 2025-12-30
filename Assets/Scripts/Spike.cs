using UnityEngine;

namespace PlaneBird
{
    public class Spike : MonoBehaviour
    {
        [SerializeField] private float height = 2.5f;
        [SerializeField] private float destroyTime = 11.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            Destroy(gameObject, destroyTime);
            var randomHeight = new Vector3(transform.position.x, Random.Range(-height, height), transform.position.z);
            transform.position = randomHeight;
        }
    }
}
