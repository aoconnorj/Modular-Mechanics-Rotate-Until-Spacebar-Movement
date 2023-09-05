using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysRotateUntilSpace : MonoBehaviour
{
    private Rigidbody rb;
    public int speed = 10;
    public int r = -45;
    public Transform player;
    public Transform moveto;
    public float changeX = 0f;
    public float changeY = 0f;
    public float x = 0.0f;
    public float y = 0.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(x, y);
        changeX = moveto.position.x - player.position.x;
        changeY = moveto.position.y - player.position.y;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            r = 0;
            x = player.transform.position.x + changeX;
            y = player.transform.position.y + changeY;
            transform.position = new Vector2(x, y);
        }
        else
        {
            r = -45;
        }

        transform.Rotate(new Vector3(0, 0, r) * Time.deltaTime);
    }
}

