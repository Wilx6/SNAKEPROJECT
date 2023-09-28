using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foodd : MonoBehaviour
{
    public BoxCollider2D grid;
    // Start is called before the first frame update
    void Start()
    {
        RandomPos();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    //Function to randomize the position of food
    private void RandomPos()
    {
        Bounds bounds = grid.bounds;      //declare the limits of the space

        float x = Random.Range(bounds.min.x, bounds.max.x); //give a random value to x with in th limit

        float y = Random.Range(bounds.min.y, bounds.max.y); //give a random value to y with in th limit

        transform.position = new Vector2(Mathf.Round(x), Mathf.Round(y)); //round the values, changes position of the

    }

    //Function for collision

    void OnTriggerEnter2D(Collider2D other)
    {
        RandomPos();
    }
}
