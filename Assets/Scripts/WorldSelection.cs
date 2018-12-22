using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSelection : MonoBehaviour
{
    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public enum Country
    {
        USA,
        France,
        Japan
    }

    public Country country { private set; get; }

    public void LoadUSA()
    {
        country = Country.USA;
        SceneManager.LoadScene("main");
    }

    public void LoadFrance()
    {
        country = Country.France;
        SceneManager.LoadScene("main");
    }

    public void LoadJapan()
    {
        country = Country.Japan;
        SceneManager.LoadScene("main");
    }
}
