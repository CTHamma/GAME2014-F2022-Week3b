using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBehaviour : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public Boundary boundary;
    public float veritcalPos;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;

        transform.position += new Vector3(x, 0, 0) * Time.deltaTime;
        float clampedPosition = Mathf.Clamp(transform.position.x, boundary.min, boundary.max);
        transform.position = new Vector2(clampedPosition, veritcalPos);
    }

}
