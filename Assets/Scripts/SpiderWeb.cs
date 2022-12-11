using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpiderWeb : MonoBehaviour
{
    public TextMeshProUGUI amogusNumberTmp;
    public int amogusNum = 0;

    public AudioSource pukSesi;

    public Hand hand1;
    public Hand hand2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Collectable"))
        {
            if(collision.GetComponent<ObjectMovement>().isHold)
            {
                pukSesi.Play();
                Destroy(collision.gameObject);
                amogusNum += 1;
                amogusNumberTmp.text = "= " + amogusNum;
                hand1.GetComponent<SpriteRenderer>().color = Color.white;
                hand2.GetComponent<SpriteRenderer>().color = Color.white;
                hand1.anyObjectOnHand = false;
                hand2.anyObjectOnHand = false;
            }

        }
    }






}
