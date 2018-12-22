using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] allRespawnGo;

    [SerializeField]
    private Vector2[] allRespawnPos;

    [SerializeField]
    private Vector3[] turn90;

    private List<GameObject> allGos;

    private void Start()
    {
        Debug.Assert(allRespawnGo.Length == allRespawnPos.Length);
        Debug.Assert(allRespawnGo.Length == turn90.Length);
        allGos = new List<GameObject>();
        RespawnAll();
    }

    public void RespawnAll()
    {
        foreach (GameObject go in allGos)
            Destroy(go);
        allGos.RemoveAll(x => true);
        for (int i = 0; i < allRespawnGo.Length; i++)
        {
            GameObject go = Instantiate(allRespawnGo[i], allRespawnPos[i], Quaternion.identity);
            go.transform.rotation = Quaternion.Euler(new Vector3(-90f, 180f, 0f) + turn90[i]);
            allGos.Add(go);
        }
    }
}
