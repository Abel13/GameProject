using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundo : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
            transform.position = new Vector2(0, 10);
    }
}
