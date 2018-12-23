using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private void Start()
    {
        scoreText.text += GameObject.FindGameObjectWithTag("ScoreKeep").GetComponent<ScoreKeep>().Score;
    }
}
