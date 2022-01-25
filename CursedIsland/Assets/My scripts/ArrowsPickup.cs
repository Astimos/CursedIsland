using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsPickup : MonoBehaviour
{
    [SerializeField] int ArrowNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckArrows());
    }


    IEnumerator CheckArrows()
    {
        yield return new WaitForSeconds(1);
        if(ArrowNumber > SaveScript.ApplesLeft)
        {
            Destroy(gameObject);
        }
    }
}
