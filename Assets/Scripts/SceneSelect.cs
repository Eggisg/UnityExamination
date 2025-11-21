using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadGameScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadLoreScene()
    {
        SceneManager.LoadScene("Lore");
    }
    
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
