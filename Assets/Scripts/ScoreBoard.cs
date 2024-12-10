using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score = 0;
    [SerializeField] TMP_Text scoreText;

    public void addScore(int scorePoints)
    {
        score += scorePoints;
        scoreText.text = score.ToString();
    }
}
