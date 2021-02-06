using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager2 gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
