using UnityEngine;
using UnityEngine.InputSystem;

namespace PlaneBird.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float thrust = 100.0f;
        private Rigidbody2D _rigidbody;
        private DefaultInputActions _defaultInputActions;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _defaultInputActions = new DefaultInputActions();
            _defaultInputActions.Player.Fire.performed += OnInputFire;
            _defaultInputActions.Enable();
        }

        private void OnInputFire(InputAction.CallbackContext obj)
        {
            _rigidbody.linearVelocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * thrust,  ForceMode2D.Impulse);
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}
