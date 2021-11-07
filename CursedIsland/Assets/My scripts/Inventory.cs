using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject InventoryMenu;
    private bool InventoryActive = false;

    [SerializeField] GameObject AppleImage1;
    [SerializeField] GameObject AppleButton1;
    // Start is called before the first frame update
    void Start()
    {
        InventoryMenu.gameObject.SetActive(false);
        InventoryActive = false;
        Cursor.visible = false;

        AppleImage1.gameObject.SetActive(false);
        AppleButton1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryActive == false)
            {
                InventoryMenu.gameObject.SetActive(true);
                InventoryActive = true;
                Time.timeScale = 0f;
                Cursor.visible = true;
            }
            else if (InventoryActive == true)
            {
                InventoryMenu.gameObject.SetActive(false);
                InventoryActive = false;
                Time.timeScale = 1f;
                Cursor.visible = false;
            }
        }

        CheckInventory();
    }

    void CheckInventory()
    {
        if (SaveScript.Apples == 1) 
        {
            AppleImage1.gameObject.SetActive(true);
            AppleButton1.gameObject.SetActive(true);
        }
    
    }
}
