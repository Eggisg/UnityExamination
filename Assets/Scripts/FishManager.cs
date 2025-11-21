using UnityEngine;
using UnityEngine.UI;

public class FishManager : MonoBehaviour
{
    public int fishCollected;
    public Text fishCollectedText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fishCollectedText.text = "Fish Collected: " + fishCollected.ToString();
        
    }
}
