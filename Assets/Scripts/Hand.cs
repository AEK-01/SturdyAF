using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField]
    int _handId = 0;

    public bool anyObjectOnHand = false;
    Eklem eklem;
    // Start is called before the first frame update
    void Start()
    {
        eklem = FindObjectOfType<Eklem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && eklem.dirsekId == _handId)
        {
            for(int i = 0; i<transform.childCount;i++)
            {
                if(transform.GetChild(i).tag == "Collectable")
                {
                    transform.GetChild(i).GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                    transform.GetChild(i).GetComponent<Rigidbody2D>().velocity = transform.GetChild(i).transform.position - transform.position;
                    transform.GetChild(i).GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

                    transform.GetChild(i).GetComponent<ObjectMovement>().isHold = false;
                    transform.GetChild(i).parent = null;
                    anyObjectOnHand = false;
                }
                
            }

            GetComponent<SpriteRenderer>().color = Color.white;

        }

        if(eklem.dirsekId != _handId)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).tag == "Collectable")
                {
                    transform.GetChild(i).GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                    transform.GetChild(i).GetComponent<Rigidbody2D>().velocity = transform.GetChild(i).transform.position - transform.position;
                    transform.GetChild(i).GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

                    transform.GetChild(i).GetComponent<ObjectMovement>().isHold = false;
                    transform.GetChild(i).parent = null;
                    anyObjectOnHand = false;
                }

            }
            GetComponent<SpriteRenderer>().color = Color.white;
        }

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && eklem.dirsekId == _handId)
        {
            GetComponent<SpriteRenderer>().color -= new Color(0, 0.05f, 0.05f, 0);
        }
    }





    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("dokundu");
        if (collision.gameObject.tag == "Collectable" && !anyObjectOnHand && Input.GetKey(KeyCode.Space) && eklem.dirsekId == _handId)
        {
            collision.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.transform.GetComponent<Rigidbody2D>().angularVelocity = 0;
            collision.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic; 
            collision.transform.SetParent(transform);
            anyObjectOnHand = true;

            collision.gameObject.GetComponent<ObjectMovement>().isHold = true;

        }
    }


}
