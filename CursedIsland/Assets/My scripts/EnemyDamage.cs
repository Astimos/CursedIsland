using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int EnemyHealth = 100;
    private AudioSource MyPlayer;
    [SerializeField] AudioSource StabPlayer;
    private bool HasDied = false;
    private Animator Anim;
    [SerializeField] GameObject EnemyObject;
    // Start is called before the first frame update
    void Start()
    {
        MyPlayer = GetComponent<AudioSource>();
        Anim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0) 
        {
            if (HasDied == false) 
            {
                Anim.SetTrigger("Death");
                HasDied = true;

                Destroy(EnemyObject, 25f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Knife")) 
        {
            EnemyHealth -= 25;
            MyPlayer.Play();
            StabPlayer.Play();
        }
    }
}
