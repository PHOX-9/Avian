using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sounds;

    public AudioClip jump;
    public AudioClip GameOver;

    public void PlaySFX(AudioClip clip)
    {
        sounds.PlayOneShot(clip);
    }
}
