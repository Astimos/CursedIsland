using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    private Animator Anim;
    public float AttackStamina;
    [SerializeField] float AttackDrain = 2;
    [SerializeField] float AttackRefill = 1;
    [SerializeField] float MaxAttackStamina = 10;
    [SerializeField] GameObject Pointer;
    [SerializeField] AudioClip GunShotSound;
    [SerializeField] AudioClip BowShotSound;
    [SerializeField] AudioSource MyPlayer;
    

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        AttackStamina = MaxAttackStamina;
        Pointer.gameObject.SetActive(true);   
    }

    // Update is called once per frame
    void Update()
    {
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
            if (SaveScript.InventoryOpen == false && SaveScript.OptionsOpen == false)
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

                if (SaveScript.HaveGun == true)
                {
                    if (Input.GetKey(KeyCode.Mouse1))
                    {
                        Anim.SetBool("AimGun", true);
                        Pointer.gameObject.SetActive(false);
                    }
                    if (Input.GetKeyUp(KeyCode.Mouse1))
                    {
                        Anim.SetBool("AimGun", false);
                        Pointer.gameObject.SetActive(true);
                    }

                    if (Input.GetMouseButtonDown(0))
                    {
                        if (SaveScript.Bullets > 0)
                        {
                            MyPlayer.clip = GunShotSound;
                            // MyPlayer.Play();
                        }
                    }
                }

                if (SaveScript.HaveCrossbow == true)
                {
                    if (Input.GetKey(KeyCode.Mouse1))
                    {
                        Anim.SetBool("AimCrossbow", true);
                        Pointer.gameObject.SetActive(false);
                    }
                    if (Input.GetKeyUp(KeyCode.Mouse1))
                    {
                        Anim.SetBool("AimCrossbow", false);
                        Pointer.gameObject.SetActive(true);
                    }

                    if (Input.GetMouseButtonDown(0))
                    {
                        if (SaveScript.Arrows > 0)
                        {
                            MyPlayer.clip = BowShotSound;
                            // MyPlayer.Play();
                        }
                    }
                }
            }
        }
    }
}
