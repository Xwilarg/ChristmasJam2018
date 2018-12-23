using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    private const float refTimer = 8f;

    private float timer;

    private void Start()
    {
        timer = refTimer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f || Input.anyKeyDown)
            SceneManager.LoadScene("MainMenu");
    }
}
