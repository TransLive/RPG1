using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPG1.Assets.Scripts.Player
{
    public class playerHealth : MonoBehaviour
    {
        public float fullHealth;
        float currentHealth;
        playerController controlMovement;
		public GameObject deathFX;
        // Use this for initialization
        void Start()
        {
            currentHealth = fullHealth;
            controlMovement = GetComponent<playerController>();
        }

		public void addDamage(float damage)
		{
			if(damage <= 0 )
                return;
            currentHealth -= damage;

			if(currentHealth <= 0)
			{
                makeDead();
            }
        }

        private void makeDead()
        {
            Instantiate(deathFX, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}