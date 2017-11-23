using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileController : MonoBehaviour {

    public float rocketSpeed;
    Rigidbody2D myRB;
    // Use this for initialization
    void Start () {
        myRB = GetComponent<Rigidbody2D>();
        if (transform.localRotation.z > 0)
        {
            Debug.Log(transform.localRotation.z);
            myRB.AddForce(new Vector2(-1, 0) * rocketSpeed, ForceMode2D.Impulse);
        }
        else
        {
            myRB.AddForce(new Vector2(1, 0) * rocketSpeed, ForceMode2D.Impulse);
        }
    }

    public void removeForce()
    {
        myRB.velocity = new Vector2(0, 0);
    }
}
