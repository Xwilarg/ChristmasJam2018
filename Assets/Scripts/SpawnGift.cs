using System.Collections.Generic;
using UnityEngine;

public class SpawnGift : MonoBehaviour
{
    [SerializeField]
    private GameObject giftPrefab;

    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private GameObject[] pannels;

    private List<GameObject> spawned;

    private void Start()
    {
        spawned = new List<GameObject>();
        SpawnAll();
    }

    private void SpawnAll()
    {
        foreach (GameObject go in pannels)
            spawned.Add(Instantiate(go, canvas.transform));
    }

    public void Spawn()
    {
        Instantiate(giftPrefab, Vector3.zero, Quaternion.identity);
        foreach (GameObject go in spawned)
            Destroy(go);
        spawned.RemoveAll(x => true);
        SpawnAll();
    }
}
