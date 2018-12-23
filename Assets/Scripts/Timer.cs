using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private const float maxTimer = 3f * 60f;
    private float currTime;

    public int finalScore { private set; get; }

    private Text timerText;

    private void Start()
    {
        currTime = maxTimer;
        timerText = GetComponent<Text>();
    }

    private void Update()
    {
        currTime -= Time.deltaTime;
        if (currTime < 0f)
        {
            GameObject.FindGameObjectWithTag("ScoreKeep").GetComponent<ScoreKeep>().Score =
                int.Parse(GameObject.FindGameObjectWithTag("Score").GetComponent<Text>().text.Split(' ').Last());
            SceneManager.LoadScene("GameOver");
        }
        timerText.text = "Remaining time: " + (int)(currTime / 60) + ":" + FormatNb((int)(currTime % 60));
    }

    private string FormatNb(int nb)
    {
        if (nb > 9)
            return (nb.ToString());
        return ("0" + nb);
    }
}
