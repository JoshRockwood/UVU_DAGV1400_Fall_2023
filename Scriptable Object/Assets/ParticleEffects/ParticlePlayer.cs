using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void Start()
    {
        // Particle system is initially stopped
        particleSystem.Stop();
    }

    public void PlayParticles()
    {
        particleSystem.Play();
    }
}
