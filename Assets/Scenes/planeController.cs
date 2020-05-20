using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class planeController : MonoBehaviour {
    private float dist;
    private Vector3 offset;
    private Transform toDrag;
    public GameObject bullet;
    public float fireEvry;
    private float nextActionTime = 0.0f;
    private float instentiationTime;

    // Start is called before the first frame update
    void Start () {
        toDrag = transform;
        instentiationTime = Time.time;

    }

    // Update is called once per frame
    void Update () {
        if (Time.time - instentiationTime > nextActionTime) {
            nextActionTime += fireEvry;
            fire ();
        }
    }

    private void fire () {
        GameObject.Instantiate (bullet, transform.position, Quaternion.identity);
    }

    [Obsolete]
    private void OnCollisionEnter2D (Collision2D other) {

        if (other.gameObject.tag != "bonus" && other.gameObject.tag != "bullet") {
            Application.LoadLevel (Application.loadedLevel);

        }
    }

}
