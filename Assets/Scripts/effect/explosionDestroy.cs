using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionDestroy : MonoBehaviour {

    public float aliveTime;
    void Awake () {
        Destroy(gameObject, aliveTime);
    }
}
