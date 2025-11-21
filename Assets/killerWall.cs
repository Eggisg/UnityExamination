using UnityEngine;
using UnityEngine.SceneManagement;
public class killerWall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene("Main");
    }
}
