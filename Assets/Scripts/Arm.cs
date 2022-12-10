using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    public Transform armPart1;
    public Transform armPart2;

    public void RotatePartOne(float speed)
    {
        armPart1.Rotate(new Vector3(0, 0, speed));
    }
    public void RotatePartTwo(float speed)
    {
        armPart2.Rotate(new Vector3(0, 0, speed));
    }
}
