using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public FishManager fishManager;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        fishManager.fishCollected++;
        Destroy(this.gameObject);
    }
}
