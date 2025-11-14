using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportOnSceneLoad : MonoBehaviour
{
    // Einzelne Positionswerte für die Zielposition
    public float targetX = 0f;
    public float targetY = 0f;
    public float targetZ = 0f;

    // Das Transform, das teleportiert werden soll (optional, falls nicht das aktuelle GameObject)
    public Transform objectToTeleport;
    void Start()
    {
        objectToTeleport.position = new Vector3(targetX, targetY, targetZ);
    }
}
