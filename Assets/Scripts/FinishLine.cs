using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 2f;
    private AudioSource finishSound;

    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("You finished!Good for you!");
            Invoke("ReloadScene",loadDelay);
            finishSound.Play();
        }


    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }

}
