using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{ Vector2 direction; //Controls Movement
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(W)) {
            direction = Vector2.up
        }

        else if (Input.GetKeyDown(A)) {
            direction = Vector2.left
        }

        else if (Input.GetKeyDown(S)) {
            direction = Vector2.down
        }

        else if (Input.GetKeyDown(D)) {
            direction = Vector2.right
        }
    }

    void FixedUpdate()
    {
        this.transform.postion = new Vector2(
            Mathf.Round(this.transform.postion.x) + direction.x
            Mathf.Round(this.transform.postion.y) + direction.y
            );
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Transform segment = Instantiate(this.body)

    }







}
