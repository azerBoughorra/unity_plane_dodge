using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletController : MonoBehaviour {
    // Start is called before the first frame update
    public float speed = 3;
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Vector2 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
        if (transform.position.y >= 6) {
            Destroy (this.gameObject);
        }
    }
    

}
