using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG1.Assets.Scripts.Player
{
    public partial class playerController
    {
        bool isOnGround = false;
        float groundCheckRadius = 0.2f;
        public LayerMask groundLayer;
        public Transform groundCheck;
        public float jumpForce;
        private void checkIsOnGround()
        {
            isOnGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
            myAnim.SetBool("isGrounded", isOnGround);
            myAnim.SetFloat("verticalSpeed", myRB.velocity.y);
        }
        private void playerJump()
        {
            if (isOnGround && Input.GetAxis("Jump") > 0 && myRB.velocity.y <= 0)
            {
                isOnGround = false;
                myAnim.SetBool("isGrounded", isOnGround);
                myRB.AddForce(new Vector2(0, jumpForce));
            }
        }
    }
}