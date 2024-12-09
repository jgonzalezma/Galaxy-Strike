using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] float resetDelay = 0.5f;
    public void RestartGame()
    {
        StartCoroutine(ResetGameSession());
    }

    IEnumerator ResetGameSession()
    {
        yield return new WaitForSecondsRealtime(resetDelay);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
