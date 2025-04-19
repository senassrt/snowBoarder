using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private ParticleSystem dieEffect;
    [SerializeField] private float timeToDie = 1f;
    private AudioSource crachSound;
    private PlayerController playerController;

    void Start()
    {
        crachSound = GetComponent<AudioSource>();
        playerController = FindFirstObjectByType<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground"){

            Debug.Log("Ouch i hit my head!");
            Invoke("ReloadScene",timeToDie);
            dieEffect.Play();
            crachSound.Play();
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
