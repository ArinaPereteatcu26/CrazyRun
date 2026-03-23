using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] float startTime = 5f; 

    void Start()
    {
        audioSource.time = startTime;
        audioSource.Play();
    }
}