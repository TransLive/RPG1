using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPG1.Assets.Scripts.Player
{
    public partial class playerController
    {
        public Transform gunTip;
        public GameObject bullet;
        float fireRate = 0.2f;//shoot one bullet per sec
        float fireCD = 0f;

        void shoot()
        {
            if(Input.GetAxisRaw("Fire1") > 0)
            {
                fireRocket();
            }
        }

        void fireRocket()
        {
            if(Time.time > fireCD)
            {
                fireCD = Time.time + fireRate;
                if(facingRight)
                {
                    Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                }
                else if(!facingRight)
                {
                    Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 180f)));
                }
            }
        }
    }
}