using UnityEngine;

public class coinCollectionRed : MonoBehaviour
{
    // Assign the explosion prefab in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            // Instantiate explosionPrefab if it's not null
            

            // Destroy the coin
            Destroy(other.gameObject);
        }
    }
}
