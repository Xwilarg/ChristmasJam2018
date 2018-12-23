using System.Collections.Generic;
using UnityEngine;

public class SpawnGift : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private GameObject[] pannels;

    private List<GameObject> spawned;

    private float currentScore;

    public float GetScore()
    {
        return (currentScore);
    }

    private void Start()
    {
        spawned = new List<GameObject>();
        SpawnAll();
    }

    public void IncreaseScore(float score)
    {
        currentScore += score;
    }

    private void SpawnAll()
    {
        currentScore = 0f;
        foreach (GameObject go in pannels)
            spawned.Add(Instantiate(go, canvas.transform));
    }

    public void Spawn()
    {
        foreach (GameObject go in spawned)
            Destroy(go);
        spawned.RemoveAll(x => true);
        SpawnAll();
    }
}
