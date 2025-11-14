using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TTSSystem : MonoBehaviour
{
    [System.Serializable]
    public class TTSClip
    {
        public int index;
        public AudioClip clip;
    }

    [Header("TTS Settings")]
    [SerializeField] private List<TTSClip> clips = new List<TTSClip>();
    [SerializeField] private AudioSource audioSource;

    private Dictionary<int, AudioClip> clipDictionary = new Dictionary<int, AudioClip>();

    void Awake()
    {
        // Initialize dictionary for quick lookups
        foreach (var ttsClip in clips)
        {
            if (!clipDictionary.ContainsKey(ttsClip.index))
            {
                clipDictionary.Add(ttsClip.index, ttsClip.clip);
            }
            else
            {
                Debug.LogWarning($"Duplicate index {ttsClip.index} found in TTS clips!");
            }
        }

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void Play(int index)
    {
        if (clipDictionary.TryGetValue(index, out AudioClip clip))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }

            audioSource.clip = clip;
            audioSource.Play();
            Debug.Log($"Playing TTS clip for index {index}");
        }
        else
        {
            Debug.LogWarning($"No TTS clip found for index {index}");
        }
    }

    // Optional: Add method to preload audio clips
    public void PreloadClips()
    {
        foreach (var clip in clips)
        {
            if (clip.clip != null && clip.clip.loadState == AudioDataLoadState.Unloaded)
            {
                clip.clip.LoadAudioData();
            }
        }
    }
}