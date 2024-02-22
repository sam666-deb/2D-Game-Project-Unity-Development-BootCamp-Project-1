using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10.0f;

    private Rigidbody2D playerRb;

    private Vector2 direction;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxis("Vertical");
        direction = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2(0, direction.y * speed);
    }
}
