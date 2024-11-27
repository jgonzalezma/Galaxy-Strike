using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] int vida = 4;
    private void OnParticleCollision(GameObject other)
    {
        vida--;
        if (vida <= 0)
        {
            Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
