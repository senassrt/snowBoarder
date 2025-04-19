using UnityEngine;

public class SnowPartiicles : MonoBehaviour
{
    [SerializeField] private ParticleSystem snowParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground"){
            snowParticles.Play();
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground"){
            snowParticles.Stop();
        }
    }
}
