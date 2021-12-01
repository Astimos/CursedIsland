using UnityEngine;

namespace Nokobot.Assets.Crossbow
{
    public class CrossbowShoot : MonoBehaviour
    {
        public GameObject arrowPrefab;
        public Transform arrowLocation;

        public float shotPower = 100f;

        void Start()
        {
            if (arrowLocation == null)
                arrowLocation = transform;
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.Mouse1) && Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (SaveScript.Arrows > 0)
                {
                    Instantiate(arrowPrefab, arrowLocation.position, arrowLocation.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
                }
            }
        }
    }
}
