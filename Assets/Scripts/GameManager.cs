using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private const string GAME_SCENE_NAME = "Game";

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI pointsText;

    private int _points;

    public void AddPoints()
    {
        _points++;
        pointsText.text = _points.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(GAME_SCENE_NAME);
        Time.timeScale = 1.0f;
    }
}
