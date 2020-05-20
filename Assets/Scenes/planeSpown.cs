using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class planeSpown : MonoBehaviour {
    // Start is called before the first frame update
    private float nextActionTime = 0.0f;
    public float spawnEvry = 3;
    public GameObject[] planes;
    private float limitY = 2;
    private float begun;

    void Start () {
        begun = Time.time;
    }

    // Update is called once per frame
    void Update () {
        if (Time.time - begun > nextActionTime) {
            nextActionTime += spawnEvry;
            spawn ();
        }

    }

    private void spawn () {
        float xPos = Random.Range (-limitY, limitY);
        GameObject plane = planes[Random.Range (0, planes.Length)];
        Vector2 position = transform.position;
        position.x = xPos;
        GameObject.Instantiate (plane, position, Quaternion.Euler (0, 0, 180));

    }
}
