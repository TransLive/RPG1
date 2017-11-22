using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPG1.Assets.Scripts.Player
{
    public partial class playerController : MonoBehaviour
    {

        //movement variable
        public float maxSpeed;
        Rigidbody2D myRB;//located to players RB2d
        Animator myAnim;
        bool facingRight;

        // Use this for initialization
        void Start()
        {
            myRB = GetComponent<Rigidbody2D>();
            myAnim = GetComponent<Animator>();
            facingRight = true;
        }

        // Update is called once per frame
		void Update()
        {
            playerJump();
            shoot();
        }

        void FixedUpdate()
        {
            //check if on ground,if no,then falling
            checkIsOnGround();
            move();
        }
    }
}