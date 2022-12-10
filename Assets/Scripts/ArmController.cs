using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{
    private int whichArm = 0;
    public List<Arm> arms;
    public float Arm1speed = 1.0f;
    public float Arm2speed = 1.0f;
    private void Update()
    { 
        if(Input.GetKeyDown(KeyCode.LeftShift))
            whichArm = whichArm+1 == arms.Count ? 0 : whichArm+1;

        if (Input.GetKey(KeyCode.Z))
            arms[whichArm].RotatePartOne(Arm1speed);
        if (Input.GetKey(KeyCode.X))
            arms[whichArm].RotatePartOne(-Arm1speed);

        if (Input.GetKey(KeyCode.Comma))
            arms[whichArm].RotatePartTwo(Arm2speed);
        if (Input.GetKey(KeyCode.Period))
            arms[whichArm].RotatePartTwo(-Arm2speed);
    }
}
