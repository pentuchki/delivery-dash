using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField]float destroyDelay = 0.01f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up package");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
        }
        if(collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered the package");
            hasPackage = false;
            Destroy(collision.gameObject, destroyDelay);
        }
    }
}
