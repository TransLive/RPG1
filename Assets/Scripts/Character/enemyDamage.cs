using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG1.Assets.Scripts.Player;
public class enemyDamage : MonoBehaviour {
    public float damage;
    public float damageRage;
    public float pushBackForce;
    float nextDamage;
    // Use this for initialization
    void Start () {
        nextDamage = 0f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if(other.CompareTag("Player") && nextDamage <= Time.time)
		{
            playerHealth thePlayerHealth = other.gameObject.GetComponent<playerHealth>();
            thePlayerHealth.addDamage(damage);
			//當 player 進入 trigger 後，因為會用當前時間加上一個δ，所以第一次觸發 nextDamage = Time.time+ damageRage 之後，在之後 damageRage 期間，此條件句不會成立，直到 Time.time 減去此時的 Time.time 大於 damageRage 時才會觸發下一次傷害
            nextDamage = Time.time+ damageRage;
            Debug.Log(nextDamage);
            pushBack(other.transform);
        }	
	}

	void pushBack(Transform pushedObject)
	{
        Vector2 pushDirection = new Vector2(0, pushedObject.position.y - transform.position.y).normalized;
        pushDirection *= pushBackForce;
        Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        pushRB.velocity = Vector2.zero;
        pushRB.AddForce(pushDirection, ForceMode2D.Impulse);
    }
}
