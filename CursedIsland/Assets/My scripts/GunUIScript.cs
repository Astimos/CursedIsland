using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunUIScript : MonoBehaviour
{
    public float time1;
    public float timer1;


    [SerializeField] Text BulletAmt;

    // Start is called before the first frame update
    void Start()
    {
        time1 = 0.67f;
        timer1 = time1;
        BulletAmt.text = SaveScript.Bullets + "";
    }

    // Update is called once per frame
    void Update()
    {
        BulletAmt.text = SaveScript.Bullets + "";
        timer1 -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse1) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(SaveScript.Bullets > 0)
            {
                if(timer1 < 0.01f) 
                { 
                    SaveScript.Bullets -= 1;
                    timer1 = time1;
                }
            }
        }
    }
}
