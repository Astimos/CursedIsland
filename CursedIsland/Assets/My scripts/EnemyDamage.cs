using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    // Start is called before the first frame update
    void Start()
    {
        MyPlayer = GetComponent<AudioSource>();
        Anim = GetComponentInParent<Animator>();
        BloodSpatKnife.gameObject.SetActive(false);
        BloodSpatBat.gameObject.SetActive(false);
        BloodSpatAxe.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0) 
        {
            if (HasDied == false) 
            {
                Anim.SetTrigger("Death");
                Anim.SetBool("IsDead", true);
                HasDied = true;

                Destroy(EnemyObject, 25f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PKnife")) 
        {
            EnemyHealth -= 10;
            MyPlayer.Play();
            StabPlayer.Play();
            BloodSpatKnife.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("PAxe"))
        {
            EnemyHealth -= 20;
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
    }
}
