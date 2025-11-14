using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    public Transform placeholderPrefab;
    public float maxDistance = 5f;
    private Transform playerTransform;
    private string placeholderTag;

    private void Start()
    {
        playerTransform = transform;

        if (placeholderPrefab != null)
        {
            placeholderTag = placeholderPrefab.tag;
        }
        else
        {
            Debug.LogError("Placeholder Prefab is not set!");
        }
    }

    private void Update()
    {
        if (string.IsNullOrEmpty(placeholderTag))
        {
            Debug.LogError("Placeholder Prefab has no valid tag.");
            return;
        }

        if (!IsNearObjectWithTag(placeholderTag))
        {
            Debug.Log("Spieler ist zu weit vom weg entfernt");
        }
        
        
    }

    private bool IsNearObjectWithTag(string tag)
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);

        foreach (GameObject obj in taggedObjects)
        {
            float distance = Vector3.Distance(playerTransform.position, obj.transform.position);

            if (distance <= maxDistance)
            {
                return true;
            }
        }

        return false;
    }

    // Zeigt die Range der Platzhalter an
    private void OnDrawGizmos()
    {
        if (placeholderPrefab != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(placeholderPrefab.position, maxDistance);
        }
    }
}
