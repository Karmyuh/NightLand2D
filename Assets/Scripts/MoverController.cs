using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverController : IPlayerController
{
    public float HorizontalAxis => Input.GetAxis("Horizontal") * Time.deltaTime;

    public float VerticalAxis => Input.GetAxis("Vertical") * Time.deltaTime;

    public float JumpAxis => Input.GetAxis("Jump");



    public  void Horizontal(Transform _transform, float _playerSpeed, bool _isHorizonActive)
        {
        switch (_isHorizonActive)
        {
            case true:
                _transform.position += new Vector3(HorizontalAxis * _playerSpeed, 0);
                break;
            default:
                _isHorizonActive = false;
                break;
        }
    }


    public void Vertical(Transform _transform , float _climbSpeed , bool _isVerticalActive)
    {
        switch(_isVerticalActive)
        {
            case true:
               _transform.position += new Vector3(0,VerticalAxis * _climbSpeed);
                break;
                 default:
                _isVerticalActive = false;
                break;
        }
    }

    public void Jump(Rigidbody2D _rigidbody2D , float _jumpForce , bool _isJumpActive)
    {
        switch(_isJumpActive)
        {
            case true:
                _rigidbody2D.AddForce(Vector2.up * _jumpForce * JumpAxis);
                break;
            default:
                _isJumpActive = false;
                break;
        }
    }

    public void Flip(SpriteRenderer _spriteRenderer , bool _isFlipActive)
    {
        switch (_isFlipActive)
        {
            case true:
                if (HorizontalAxis <0)
                {
                    _spriteRenderer.flipX = true;
                }
                else if (HorizontalAxis > 0)
                {
                    _spriteRenderer.flipX = false;
                }
                break;
            default:
                _isFlipActive = false;
                break;
        }
    }
}
