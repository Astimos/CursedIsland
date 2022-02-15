﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    public int EnemyHealth = 100;
    private AudioSource MyPlayer;
    [SerializeField] AudioSource StabPlayer;
    public bool HasDied = false;
    private Animator Anim;
    [SerializeField] GameObject EnemyObject;
    [SerializeField] GameObject BloodSpatKnife;
    [SerializeField] GameObject BloodSpatBat;
    [SerializeField] GameObject BloodSpatAxe;
    private bool DamageOn = false;
    [SerializeField] bool IsBoss;
    [SerializeField] GameObject EnemyAttackScript;


    // Start is called before the first frame update
    void Start()
    {
        MyPlayer = GetComponent<AudioSource>();
        Anim = GetComponentInParent<Animator>();
        StartCoroutine(StartElement());
    }

    // Update is called once per frame
    void Update()
    {
        if (DamageOn == true)
        {
            if (IsBoss == false)
            {
                if (EnemyHealth <= 0)
                {
                    if (HasDied == false)
                    {
                        Anim.SetTrigger("Death");
                        Anim.SetBool("IsDead", true);
                        HasDied = true;
                        SaveScript.EnemiesOnScreen--;
                        Destroy(this.transform.parent.gameObject, 25f);
                    }
                }
            }

            if (IsBoss == true)
            {
                if (EnemyHealth <= 0)
                {
                    if (HasDied == false)
                    {
                        EnemyAttackScript.gameObject.SetActive(false);
                        Anim.SetTrigger("BossDeath");
                        HasDied = true;
                        StartCoroutine(LoadFinalScene());
                    }
                }
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PKnife")) 
        {
            EnemyHealth -= 15;
            MyPlayer.Play();
            StabPlayer.Play();
            BloodSpatKnife.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("PAxe"))
        {
            EnemyHealth -= 40;
            MyPlayer.Play();
            StabPlayer.Play();
            BloodSpatAxe.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("PBat"))
        {
            EnemyHealth -= 15;
            MyPlayer.Play();
            StabPlayer.Play();
            BloodSpatBat.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("PCrossbow"))
        {
            EnemyHealth -= 50;
            MyPlayer.Play();
            StabPlayer.Play();
            Destroy(other.gameObject, 0.05f);
        }
    }


    IEnumerator StartElement()
    {
        yield return new WaitForSeconds(0.1f);
        StabPlayer = SaveScript.StabSound;
        BloodSpatKnife = SaveScript.SplatKnife;
        BloodSpatBat = SaveScript.SplatBat;
        BloodSpatAxe = SaveScript.SplatAxe;
        BloodSpatKnife.gameObject.SetActive(false);
        BloodSpatBat.gameObject.SetActive(false);
        BloodSpatAxe.gameObject.SetActive(false);
        DamageOn = true;
    }

    IEnumerator LoadFinalScene()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(4);
    }
}
