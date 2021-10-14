using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rdb;

    // Start is called before the first frame update
    void Start()
    {
        rdb = GetComponent<Rigidbody2D>();
        rdb.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > Camera.main.orthographicSize)
            Destroy(gameObject);
    }
}
