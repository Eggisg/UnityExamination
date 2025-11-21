using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public FishManager fishManager;
    public AudioSource audioSource;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        fishManager.fishCollected++;
        audioSource.Play();
        Destroy(this.gameObject);
    }
}
