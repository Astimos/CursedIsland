using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotScript : MonoBehaviour
{
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (SaveScript.HaveGun == true) 
        {
            if (Input.GetKey(KeyCode.Mouse1) && Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (SaveScript.Bullets > 0)
                {
                    if (Physics.Raycast(transform.position, transform.forward, out hit, 3000))
                    {
                        if (hit.transform.Find("Body"))
                        {
                            hit.transform.gameObject.GetComponentInChildren<EnemyDamage>().EnemyHealth -= Random.Range(30, 101);
                            hit.transform.gameObject.GetComponent<Animator>().SetTrigger("BigReact");
                            Debug.Log("Shoot enemy");
                        }
                    }
                }
            }
        }
    }
}
