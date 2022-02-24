using Core.Entities.Controllers;
using Core.Input.Keys;

using System.Collections;
using UnityEngine;

namespace Core.Entities.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : InputBlock
    {
        [Header("Parameters")]
        [SerializeField] private float _powerMove = 1f;
        [SerializeField] private float _powerJump = 1f;
        [SerializeField] private float _powerDash = 1f;
        [SerializeField] private float _timeDash = 0.3f;

        [Header("Buttons statuses (debug vision)")]
        [SerializeField] private bool _keyLeft = false;
        [SerializeField] private bool _keyRight = false;
        [SerializeField] private bool _keyJump = false;
        [SerializeField] private bool _keyDash = false;

        private bool _isJump = false;
        private bool _isDash = false;
        private Coroutine _dashTimer;

        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public override void SetKeyDown(KeyMovement key)
        {
            switch (key)
            {
                case KeyMovement.Left:
                    _keyLeft = true;
                    break;
                case KeyMovement.Right:
                    _keyRight = true;
                    break;
#if UNITY_EDITOR
                case KeyMovement.Undefined:
                    Debug.Log("Button is undefined");
                    break;
#endif
            }
            UpdateMovement();
        }
        public override void SetKeyUp(KeyMovement key)
        {
            switch (key)
            {
                case KeyMovement.Left:
                    _keyLeft = false;
                    break;
                case KeyMovement.Right:
                    _keyRight = false;
                    break;
#if UNITY_EDITOR
                case KeyMovement.Undefined:
                    Debug.Log("Button is undefined");
                    break;
#endif
            }
            UpdateMovement();
        }

        public override void SetKeyDown(KeyWorldInteraction key)
        {
            switch (key)
            {
                case KeyWorldInteraction.Jump:
                    _keyJump = true;
                    break;
                case KeyWorldInteraction.Dash:
                    _keyDash = true;
                    break;
#if UNITY_EDITOR
                case KeyWorldInteraction.Undefined:
                    Debug.Log("Button is undefined");
                    break;
#endif
            }
            UpdateMovement();
        }
        public override void SetKeyUp(KeyWorldInteraction key)
        {
            switch (key)
            {
                case KeyWorldInteraction.Jump:
                    _keyJump = false;
                    break;
                case KeyWorldInteraction.Dash:
                    _keyDash = false;
                    break;
#if UNITY_EDITOR
                case KeyWorldInteraction.Undefined:
                    Debug.Log("Button is undefined");
                    break;
#endif
            }
            UpdateMovement();
        }

        public void UpdateMovement()
        {
            float horizontalDirection = _keyLeft != _keyRight ? (_keyRight ? _powerMove : -_powerMove) : 0;
            _rb.velocity = new Vector2(horizontalDirection, 0);
        }
        public IEnumerator DashTimer()
        {
            yield return new WaitForSeconds(_timeDash);
            UpdateMovement();
        }
    }
}
