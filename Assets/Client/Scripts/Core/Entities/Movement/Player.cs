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

        private float _horizontalDirection;
        private bool _isJump = false;
        private bool _isDash = false;
        private Coroutine _dashTimer;

        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public override void Move(Vector2 direction)
        {
            _horizontalDirection = direction.x;
            UpdateMovement();
        }
        public override void Press(KeyWorldInteraction key)
        {
            switch (key)
            {
                case KeyWorldInteraction.Jump:
                    Jump();
                    break;
                case KeyWorldInteraction.Dash:
                    Dash();
                    break;
                case KeyWorldInteraction.Undefined:
                    break;
            }
        }

        private void Jump()
        {
            if (_isDash)
                return;
            _isJump = true;
            _rb.AddForce(Vector2.up * _powerJump);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (_isJump)
            {
                _isJump = false;
            }
        }

        private void Dash()
        {
            if (_isDash)
                return;
            _isDash = true;
            UpdateMovement();

            if (_dashTimer != null)
                StopCoroutine(_dashTimer);
            _dashTimer = StartCoroutine(DashTimer());
        }
        private IEnumerator DashTimer()
        {
            yield return new WaitForSeconds(_timeDash);
            _isDash = false;
            UpdateMovement();
        }

        private void UpdateMovement()
        {
            if (_isDash)
                _rb.velocity = new Vector2(Mathf.Floor(_horizontalDirection) * _powerDash, _rb.velocity.y);
            else
                _rb.velocity = new Vector2(_horizontalDirection * _powerMove, _rb.velocity.y);
        }
    }
}
