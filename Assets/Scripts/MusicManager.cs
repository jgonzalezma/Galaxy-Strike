using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private void Start()
    {
        int numOfMusicPlayers = FindObjectsByType<MusicManager>(FindObjectsSortMode.None).Length;

        if (numOfMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
