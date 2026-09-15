using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    private bool isGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // show the starts screen
        CanvasGroupDisplayer.Show(CanvasGroup);
    }
    
    public void OnStartButtonClicked()
    {
        // hide the start screen
        CanvasGroupDisplayer.Hide(CanvasGroup);
        // remember that the game has started
        isGameStarted = true;
    }
}
