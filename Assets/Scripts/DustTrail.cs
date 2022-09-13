using UnityEngine;

public class DustTrail : MonoBehaviour
{
    CapsuleCollider2D capsuleCollider2D;
    [SerializeField] ParticleSystem dustTrailEffect;
    
    void Start() 
    {
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
            dustTrailEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
            dustTrailEffect.Stop();
        }
    }
}
