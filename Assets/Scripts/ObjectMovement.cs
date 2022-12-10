using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{


    public float speed = 0.2f;

    public float angularSpeed = 10;

    float angularSpeedMultiplyer = 1;

    public Vector2 directionOfMovement;
    int x;
    int y;
    // Start is called before the first frame update
    void Start()
    { 
        x = Random.Range(-1000, 1000);
        y = Random.Range(-1000, 1000);

        directionOfMovement = new Vector2(x, y).normalized;

        angularSpeedMultiplyer = Random.Range(10, 10);


        GetComponent<Rigidbody2D>().velocity = directionOfMovement * speed;
        GetComponent<Rigidbody2D>().angularVelocity = angularSpeed * angularSpeedMultiplyer;

    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
