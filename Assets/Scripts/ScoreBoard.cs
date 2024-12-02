using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score = 0;
    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        score = 0;
    }
    public void addScore(int scorePoints)
    {
        score += scorePoints;
        scoreText.text = scorePoints.ToString();
    }
}
