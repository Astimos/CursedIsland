using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] float Distance = 4.0f;
    [SerializeField] GameObject PickupMessage;
    private AudioSource MyPlayer;

    private float RayDistance;
    private bool CanSeePickup = false;

    // Start is called before the first frame update
    void Start()
    {
        PickupMessage.gameObject.SetActive(false);
        RayDistance = Distance;
        MyPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, RayDistance))
        {
            if (hit.transform.tag == "Apple")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.Apples < 6)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.Apples += 1;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "Knife")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.Knife == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.Knife = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "Axe")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.Axe == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.Axe = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "Crossbow")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.Crossbow == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.Crossbow = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "Bat")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.Bat == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.Bat = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "Gun")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.Gun == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.Gun = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "CabinKey")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.CabinKey == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.CabinKey = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "RoomKey")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.RoomKey == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.RoomKey = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "HouseKey")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.HouseKey == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.HouseKey = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "Battery")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.Batteries < 4)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.Batteries += 1;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "Arrows")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.ArrowRefill == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.ArrowRefill = true;
                        MyPlayer.Play();
                    }
                }
            }
            else if (hit.transform.tag == "Ammo")
            {
                CanSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScript.BulletClips < 4)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScript.BulletClips += 1;
                        MyPlayer.Play();
                    }
                }
            }
            else
            {
                CanSeePickup = false;
            }

        }

                if (CanSeePickup == true)
                {
                    PickupMessage.gameObject.SetActive(true);
                    RayDistance = 1000f;
                }
                if (CanSeePickup == false)
                {
                    PickupMessage.gameObject.SetActive(false);
                    RayDistance = Distance;
                }
    }
}
