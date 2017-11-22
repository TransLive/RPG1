using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPG1.Assets.Scripts.Player
{
    public partial class playerController
    {
        private void move()
        {
            float move = Input.GetAxis("Horizontal");
            myAnim.SetFloat("speed", Mathf.Abs(myRB.velocity.x));
            myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);

            //速度方向為正且未朝右的情況下，翻轉sprite
            if (move > 0 && !facingRight)
            {
                flip();
            }
            //反之
            else if (move < 0 && facingRight)
            {
                flip();
            }
        }

        private void flip()
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}