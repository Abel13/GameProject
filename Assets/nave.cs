using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour
{
    public GameObject shot;
    public AudioSource shotSound;
    public float speed;

    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    private float width;
    private float height;

    private Rigidbody2D rbd;

    // Start is called before the first frame update
    void Start()
    {
        shotSound = GetComponent<AudioSource>();
        rbd = GetComponent<Rigidbody2D>();
        height = Camera.main.orthographicSize;
        width = height * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis(Horizontal);
        float y = Input.GetAxis(Vertical);

        rbd.velocity = new Vector2(x, y) * speed;

        checkBorders();
        checkShot();
    }

    private void checkShot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shotSound.Play();
            Instantiate(shot, transform.position, Quaternion.identity);
        }
    }

    private void checkBorders()
    {
        if (transform.position.x > width)
            transform.position = new Vector2(-width, transform.position.y);
        else if (transform.position.x < -width)
            transform.position = new Vector2(width, transform.position.y);


        if (transform.position.y < -height)
            transform.position = new Vector2(transform.position.x, -height);
        else if (transform.position.y > 0)
            transform.position = new Vector2(transform.position.x, 0);
    }
}
