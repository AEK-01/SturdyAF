using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    public Transform armPart1;
    public Transform armPart2;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void RotatePartOne(float speed)
    {
        armPart1.GetComponent<Rigidbody2D>().rotation += speed;
    }
    public void RotatePartTwo(float speed)
    {
        armPart2.GetComponent<Rigidbody2D>().rotation += speed;
    }
}
