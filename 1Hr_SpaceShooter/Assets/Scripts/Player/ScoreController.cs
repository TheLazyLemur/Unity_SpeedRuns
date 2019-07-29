using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public int Score { get; private set; }
    public void AddScore(int value)
    {
        Score += value;
        scoreText.text = Score.ToString();
    }
}
