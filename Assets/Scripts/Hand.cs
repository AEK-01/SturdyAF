using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    bool anyObjectOnHand = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            for(int i = 0; i<transform.childCount;i++)
            {
                if(transform.GetChild(i).tag == "Collectable")
                {
                    transform.GetChild(i).gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                    transform.GetChild(i).parent = null;
                    anyObjectOnHand = false;
                }
                
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("dokundu");
        if (collision.gameObject.tag == "Collectable" && !anyObjectOnHand && Input.GetKey(KeyCode.Space))
        {
            collision.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.transform.GetComponent<Rigidbody2D>().angularVelocity = 0;
            collision.transform.SetParent(transform);
            anyObjectOnHand = true;
        }
    }


}
