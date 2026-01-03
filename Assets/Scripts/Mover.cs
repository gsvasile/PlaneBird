using UnityEngine;

namespace PlaneBird
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 2.0f;

        // Update is called once per frame
        private void Update()
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }
}
