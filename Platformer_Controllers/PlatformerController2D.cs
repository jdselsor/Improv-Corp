using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

namespace Platformer_Controllers
{
	public class PlatformerController2D : MonoBehaviour
	{
		[SerializeField] private float _jumpForce = 400f;
		[Range(0, 1)] [SerializeField] private float _crouchSpeed = .36f;
		[Range(0, .3f)] [SerializeField] private float _movementSmoothing = .05f;
		[SerializeField] private bool _airControl = false;
		[SerializeField] private LayerMask _whatIsGround = LayerMask.GetMask();
		[SerializeField] private Transform _groundCheck = null;
		[SerializeField] private Transform _ceilingCheck = null;
		[SerializeField] private Collider2D _crouchDisableCollider = null;

		const float _GROUNDED_RADIUS = .2f;
		private bool _grouned = false;
		const float _CEILING_RADIUS = .2f;
		private Rigidbody2D _rigidbody2D;
		private bool _facingRight = true;
		private Vector3 _velocity = Vector3.zero;

		private bool _wasCrouching = false;

		private void Awake()
		{
			_rigidbody2D = GetComponent<Rigidbody2D>();
		}

		private void FixedUpdate()
		{
			bool wasGrounded = _grouned;
			_grouned = false;

			Collider2D[] colliders = Physics2D.OverlapCircleAll(_groundCheck.position, _GROUNDED_RADIUS, _whatIsGround);
			for (int i = 0; i < colliders.Length; i++)
			{
				if (colliders[i].gameObject != gameObject)
				{
					_grouned = true;
				}
			}
		}

		public void Move(float move, bool crouch, bool jump)
		{
			if (!crouch && _grouned)
			{
				if (Physics2D.OverlapCircle(_ceilingCheck.position, _CEILING_RADIUS, _whatIsGround))
				{
					crouch = true;
				}
			}

			if (_grouned || _airControl)
			{
				if (crouch)
				{
					if (!_wasCrouching)
					{
						_wasCrouching = true;
					}

					move *= _crouchSpeed;

					if (_crouchDisableCollider != null)
						_crouchDisableCollider.enabled = false;
				}
				else
				{
					if (_crouchDisableCollider != null)
						_crouchDisableCollider.enabled = true;

					if (_wasCrouching)
					{
						_wasCrouching = false;
					}
				}

				Vector3 targetVelocity = new Vector2(move * 10f, _rigidbody2D.velocity.y);
				_rigidbody2D.velocity = Vector3.SmoothDamp(_rigidbody2D.velocity, targetVelocity, ref _velocity, _movementSmoothing);

				if (move > 0 && !_facingRight)
				{
					Flip();
				}
				else if (move < 0 && _facingRight)
				{
					Flip();
				}
			}
			if (_grouned && jump)
			{
				_grouned = false;
				_rigidbody2D.AddForce(new Vector2(0f, _jumpForce));
			}
		}

		private void Flip()
		{
			_facingRight = !_facingRight;

			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
    }
}