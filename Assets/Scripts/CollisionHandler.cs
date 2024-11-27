using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.name);
        Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
