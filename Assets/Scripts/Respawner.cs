using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] allRespawnGo;

    [SerializeField]
    private Vector2[] allRespawnPos;

    private List<GameObject> allGos;

    private void Start()
    {
        Debug.Assert(allRespawnGo.Length == allRespawnPos.Length);
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
            go.transform.rotation = Quaternion.Euler(new Vector3(-90f, 0f, 0f));
            allGos.Add(go);
        }
    }
}
