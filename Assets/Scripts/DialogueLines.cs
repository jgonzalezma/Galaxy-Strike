using UnityEngine;
using TMPro;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] string[] timelineTextLines;
    [SerializeField] TMP_Text dialogueText;

    int currentIndex = 0;

    public void DisplayNextLine()
    {
        currentIndex++;
        dialogueText.text = timelineTextLines[currentIndex];
    }
}
