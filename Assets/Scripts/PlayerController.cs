using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    MoverController _moverController;
    [SerializeField] Transform _playerTransfrom;
    [SerializeField] SpriteRenderer _playerSpriteRenderer;
    [SerializeField] float _playerSpeed , _jumpForce;
    [SerializeField] bool _isHorizontalActive , _isJumpActive , _isSpaceControl , _isFlipActive;
    [SerializeField] Rigidbody2D _playerRigidBody2D;
    [SerializeField] Animator _animator;
    private void Awake()
    {
        _moverController = new MoverController();
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             _isSpaceControl = true;
        }
    }
    private void FixedUpdate()
    {
        Walk();
        Jump();
        Flip();
        


    }


    void Walk()
    {
        _moverController.Horizontal(_playerTransfrom, _playerSpeed, _isHorizontalActive);
        _animator.SetFloat("__isWalk", Mathf.Abs(Input.GetAxis("Horizontal")));
    }

    void Jump()
    {
        if (_isSpaceControl)
        {
            _moverController.Jump(_playerRigidBody2D, _jumpForce, _isJumpActive);
          //  _animator.SetBool("_isJump", _isSpaceControl);
        }
        _isSpaceControl = false;
        //_animator.SetBool("__isJump", _isSpaceControl);



    }
    void Flip()
    {
        _moverController.Flip(_playerSpriteRenderer, _isFlipActive);
    }
}
