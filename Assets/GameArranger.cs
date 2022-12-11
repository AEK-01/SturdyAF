using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameArranger : MonoBehaviour
{
    SpiderWeb spiderWeb;
    public GameObject skorPanel;
    public TextMeshProUGUI skorText;
    public Eklem eklem;
    public TextMeshProUGUI timerText;
    public float timer = 60;
    public bool timerController = false;
    // Start is called before the first frame update
    void Start()
    {
        eklem = FindObjectOfType<Eklem>();
        spiderWeb = FindObjectOfType<SpiderWeb>();
        eklem.enabled = false;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(timer <= 0)
        {
            GameEnd();

        }

        if(timerController)
        {
            timer -= Time.fixedDeltaTime;
            timerText.text = "" + timer.ToString("0.00") + " sec";
        }

        if(spiderWeb.amogusNum == 25)
        {
            GameEnd();
        }
        
    }


    public void StartFunctionality()
    {
        eklem.enabled = true;
        timerController = true;
    }


    public void GameEnd()
    {
        //todo
        skorPanel.SetActive(true);
        eklem.enabled = false;
        timerController = false; 


        if(spiderWeb.amogusNum < 25)
            skorText.text = "" + spiderWeb.amogusNum + " amogusus have been saved";
        else
            skorText.text = "ALL AMOGUSUS HAVE BEEN SAVED  IN " +  (90 - timer).ToString("0.00") + " SECONDS "  +  " YEAY";

        timerText.text = "" + "0" + " sec";
    }



}
