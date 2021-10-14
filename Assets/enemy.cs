using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float height;
    public float speed;
    private Rigidbody2D rbd;

    // Start is called before the first frame update
    void Start()
    {
        height = Camera.main.orthographicSize;
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -height)
            Destroy(gameObject);
    }
}
