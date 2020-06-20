using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerr gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
