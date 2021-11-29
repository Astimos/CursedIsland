﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    private Animator Anim;
    public float AttackStamina;
    [SerializeField] float AttackDrain = 2;
    [SerializeField] float AttackRefill = 1;
    [SerializeField] float MaxAttackStamina = 10;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        AttackStamina = MaxAttackStamina;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Attack stamina" + AttackStamina);
        if (AttackStamina < MaxAttackStamina) 
        {
            AttackStamina += AttackRefill * Time.deltaTime;
        }
        if (AttackStamina <= 0.1)
        {
            AttackStamina = 0.1f;
        }
        if (AttackStamina > 3.0)
        {
            if (SaveScript.HaveKnife == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Anim.SetTrigger("KnifeLMB");
                    AttackStamina -= AttackDrain;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    Anim.SetTrigger("KnifeRMB");
                    AttackStamina -= AttackDrain;
                }
            }
            if (SaveScript.HaveBat == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Anim.SetTrigger("BatLMB");
                    AttackStamina -= AttackDrain;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    Anim.SetTrigger("BatRMB");
                    AttackStamina -= AttackDrain;
                }
            }
            if (SaveScript.HaveAxe == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Anim.SetTrigger("AxeLMB");
                    AttackStamina -= AttackDrain;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    Anim.SetTrigger("AxeRMB");
                    AttackStamina -= AttackDrain;
                }
            }
        }
    }
}
