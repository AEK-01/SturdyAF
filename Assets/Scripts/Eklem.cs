using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eklem : MonoBehaviour
{

    public int dirsekId = 0;

    public Transform dirsek1;
    public Transform dirsek2;

    public Transform dirsek3;
    public Transform dirsek4;

    public float rotateSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Input.GetKey(KeyCode.Z))
        {
            switch(dirsekId)
            {
                case 0:
                    dirsek1.Rotate(new Vector3(0, 0, rotateSpeed));
                    break;
                case 1:
                    dirsek3.Rotate(new Vector3(0, 0, rotateSpeed));
                    break;

            }
        }
        if(Input.GetKey(KeyCode.X))
        {
            switch (dirsekId)
            {
                case 0:
                    dirsek1.Rotate(new Vector3(0, 0, -rotateSpeed));
                    break;
                case 1:
                    dirsek3.Rotate(new Vector3(0, 0, -rotateSpeed));
                    break;

            }
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            switch (dirsekId)
            {
                case 0:
                    dirsek2.Rotate(new Vector3(0, 0, rotateSpeed* 1.5f));
                    break;
                case 1:
                    dirsek4.Rotate(new Vector3(0, 0, rotateSpeed* 1.5f));
                    break;

            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            switch (dirsekId)
            {
                case 0:
                    dirsek2.Rotate(new Vector3(0, 0, -rotateSpeed*1.5f));
                    break;
                case 1:
                    dirsek4.Rotate(new Vector3(0, 0, -rotateSpeed*1.5f));
                    break;

            }
        }

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (dirsekId == 0)
            {
                dirsekId = 1;
            }
            else
            {
                dirsekId = 0;
            }
        }
    }

}
