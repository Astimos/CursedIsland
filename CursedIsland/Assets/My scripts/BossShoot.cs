using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
    [SerializeField] Animator Anim;
    [SerializeField] Transform ShootScript;
    private bool CanShoot = false;
    void Start()
    {
        ShootScript.GetComponentInChildren<SimpleShoot1>().enabled = false;  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            CanShoot = true;
            Anim.SetTrigger("AimShoot");
            StartCoroutine(ShootPlayer());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CanShoot = false;
            StartCoroutine(ShootPlayer());
        }
    }

    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(1f);
        if(CanShoot == true) 
        {
            ShootScript.GetComponentInChildren<SimpleShoot1>().enabled = true;
        }
        if (CanShoot == false)
        {
            ShootScript.GetComponentInChildren<SimpleShoot1>().enabled = false;
        }
    }
}
