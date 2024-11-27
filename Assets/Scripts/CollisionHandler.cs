using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Suelo")
        {
            Debug.Log("Colision suelo");
        }
        if (other.tag == "Enemigo")
        {
            Debug.Log("Colision enemigo");
        }
    }
}
