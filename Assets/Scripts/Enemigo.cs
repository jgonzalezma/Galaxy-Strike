using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] int vida = 4;
    [SerializeField] int scorePoint = 10;
    ScoreBoard scoreBoard;

    private void Start()
    {
        scoreBoard = FindFirstObjectByType<ScoreBoard>();
    }
    private void OnParticleCollision(GameObject other)
    {
        vida--;
        if (vida <= 0)
        {
            Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
            scoreBoard.addScore(scorePoint);
            Destroy(this.gameObject);
        }
    }
}
