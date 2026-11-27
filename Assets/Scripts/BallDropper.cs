using UnityEngine;
using UnityEngine.InputSystem;

public class BallDropper : MonoBehaviour
{

    public GameObject BallPrefab;
    
    // Update is called once per frame
    void Update()
    {
        // If the left mouse button was pressed, drop a ball!
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            DropBall();
        }
    }

    private void DropBall()
    {
        // pick a position to start at
        Vector3 spawnPosition = GetSpawnPosition();

        // create a ball at that position
        Instantiate(BallPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector3 GetSpawnPosition()
    {
        Vector3 leftEdge = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector3 rightEdge = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, Camera.main.nearClipPlane));

        float randomX = Random.Range(leftEdge.x + 1, rightEdge.x - 1);

        Vector3 spawnPosition = new Vector3(randomX, 4.5f, 0f);

        return spawnPosition;
    }
}
