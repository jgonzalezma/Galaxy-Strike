using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] int vida = 4;
    [SerializeField] int scorePoint = 10;
    [SerializeField] AudioClip enemyDestroyAudio;
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
            scoreBoard.addScore(scorePoint);
            Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(enemyDestroyAudio, Camera.main.transform.position, 5);
            Destroy(this.gameObject);
        }
    }
}
