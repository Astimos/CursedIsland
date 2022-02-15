using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot1 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject muzzleFlashPrefab;
    public GameObject barrelLocation;
    private AudioSource MyPlayer;

    public float shotPower = 1000f;

    private bool IsShooting = false;

    private void Start()
    {
        MyPlayer = GetComponent<AudioSource>();
    }
    void Update()
    {
       if(SaveScript.InventoryOpen == false && SaveScript.OptionsOpen == false)
        {
            if(IsShooting == false)
            {
                IsShooting = true;
                StartCoroutine(DelayTime());
            }
        }
    }


    //This function creates the bullet behavior
    void Shoot()
    {

        GameObject tempFlash;
        Instantiate(bulletPrefab, barrelLocation.transform.position, barrelLocation.transform.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.transform.forward * shotPower);
        tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.transform.position, barrelLocation.transform.rotation);
        Destroy(tempFlash, 0.5f);

    }


    //This function creates a casing at the ejection slot
    void CasingRelease()
    {

    }

    IEnumerator DelayTime()
    {
        GetComponent<Animator>().SetTrigger("Fire");
        MyPlayer.Play();
        yield return new WaitForSeconds(1f);
        IsShooting = false;
    }
}
