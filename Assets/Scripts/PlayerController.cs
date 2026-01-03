using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlaneBird.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float thrust = 100.0f;
        [SerializeField] private float coolDown = 4f;
        private Rigidbody2D _rigidbody;
        private DefaultInputActions _defaultInputActions;
        private float _counter;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _defaultInputActions = new DefaultInputActions();
            _defaultInputActions.Player.Fire.performed += OnInputFire;
            _defaultInputActions.Enable();
        }

        private void OnInputFire(InputAction.CallbackContext obj)
        {
            if (_counter < coolDown)
            {
                return;
            }

            _rigidbody.linearVelocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * thrust, ForceMode2D.Impulse);
            _counter = 0.0f;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!other.gameObject.CompareTag("Spike") && !other.gameObject.CompareTag("Ground"))
            {
                return;
            }
            
            Time.timeScale = 0;
        }

        // Update is called once per frame
        private void Update()
        {
            _counter += Time.deltaTime;
        }
    }
}
