using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossbowUIScript : MonoBehaviour
{
    public float time2;
    public float timer2;


    [SerializeField] Text ArrowAmount;

    // Start is called before the first frame update
    void Start()
    {
        time2 = 0.67f;
        timer2 = time2;
        ArrowAmount.text = SaveScript.Arrows + "";
    }

    // Update is called once per frame
    void Update()
    {
        ArrowAmount.text = SaveScript.Arrows + "";
        timer2 -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse1) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(SaveScript.Arrows > 0)
            {
                if(timer2 < 0.01f) 
                { 
                    SaveScript.Arrows -= 1;
                    timer2 = time2;
                }
            }
        }
    }
}
