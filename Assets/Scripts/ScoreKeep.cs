using UnityEngine;

public class ScoreKeep : MonoBehaviour
{
    [HideInInspector]
    public int Score;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
