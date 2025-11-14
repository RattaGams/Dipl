using System.Collections.Generic;
using UnityEngine;

public class PingSystem : MonoBehaviour
{
    [System.Serializable]
    public class PingTarget
    {
        public Transform transform;  
        public int number;           
    }

    [Header("Ping Settings")]
    public List<PingTarget> pingTargets = new List<PingTarget>();
    public Sprite pingSprite;
    public float proximityThreshold = 2.0f;
    public Color outlineColor = Color.red;
    public float outlineWidth = 0.1f;
    public float pingHeightOffset = 10;
    [Header("TTS System")]
    public TTSSystem ttsSystem;

    private int currentPingIndex = 0;
    private GameObject pingInstance;

    void Start()
    {
        if (pingTargets.Count > 0)
        {
            ShowPingAtCurrentTarget();
        }
        else
        {
            Debug.LogWarning("No ping targets defined!");
        }
    }

    void Update()
    {
        if (pingInstance != null && pingTargets.Count > 0)
        {
            Transform currentTarget = pingTargets[currentPingIndex].transform;
            float distance = Vector3.Distance(transform.position, currentTarget.position);

            if (distance <= proximityThreshold)
            {
                ShowNextPing();
            }

            UpdatePingRotation();
        }
    }

    void ShowPingAtCurrentTarget()
    {
        if (pingTargets.Count == 0) return;

        if (pingInstance != null)
        {
            Destroy(pingInstance);
        }

        pingInstance = new GameObject("Ping");
        pingInstance.transform.position = pingTargets[currentPingIndex].transform.position + new Vector3(0,pingHeightOffset,0);

        SpriteRenderer sr = pingInstance.AddComponent<SpriteRenderer>();
        sr.sprite = pingSprite;
        sr.sortingOrder = 100;

        if (ttsSystem != null)
        {
            ttsSystem.Play(pingTargets[currentPingIndex].number);
        }
    }

    void ShowNextPing()
    {
        currentPingIndex = (currentPingIndex + 1) % pingTargets.Count;
        ShowPingAtCurrentTarget();
    }

    void UpdatePingRotation()
    {
        if (pingInstance != null && Camera.main != null)
        {
            pingInstance.transform.rotation = Quaternion.LookRotation(
                pingInstance.transform.position - Camera.main.transform.position
            );
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        foreach (PingTarget target in pingTargets)
        {
            if (target.transform != null)
            {
                Gizmos.DrawSphere(target.transform.position, 0.25f);
                Gizmos.DrawLine(transform.position, target.transform.position);
            }
        }
    }
}