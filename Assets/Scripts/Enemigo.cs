using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    private void OnParticleCollision(GameObject other)
    {
        Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
