using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    public Text gameOverText;
    public Text scoreText;
    
    private void Awake()
    {
        var btn = gameOverText.GetComponentInChildren<Button>();
        btn.onClick.AddListener(() => SceneManager.LoadScene(0));
    }

    public void DisplayScore(int score)
    {
        gameOverText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
        scoreText.text = "Score : " + score;
    }
}