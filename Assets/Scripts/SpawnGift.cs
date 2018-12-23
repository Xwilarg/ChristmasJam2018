using System.Collections.Generic;
using UnityEngine;

public class SpawnGift : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private Schoolboard pannel1;

    [SerializeField]
    private IdCard pannel2;

    [SerializeField]
    private Wishlist pannel3;

    private List<GameObject> spawned;

    private float currentScore;

    public float GetScore()
    {
        return (currentScore);
    }

    private void Start()
    {
        spawned = new List<GameObject>();
        currentScore = 0f;
    }

    public void IncreaseScore(float score)
    {
        currentScore += score;
    }

    public void Spawn()
    {
        currentScore = 0f;
        pannel1.ResetContent();
        pannel2.ResetContent();
        pannel3.ResetContent();
    }
}
