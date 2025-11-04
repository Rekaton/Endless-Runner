using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void Update()
    {
        //Virkede ikke for en eller anden grund...
        //if (GameObject.FindGameObjectsWithTag("Player") == null)
        //{
        //    gameOverPanel.SetActive(true);
        //}

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
