using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawner : MonoBehaviour
{
    [SerializeField]
    private Button craftButton;

    private Text craftText;

    private int craftRemaining;

    [Header("Coal")]
    [SerializeField]
    private GameObject coalPrefab;

    [SerializeField]
    private Vector2 coalPos;

    [Header("Empty Gift")]
    [SerializeField]
    private GameObject emptyGiftPrefab;

    [SerializeField]
    private Vector2 emptyGiftPos;

    [Header("To spawn")]
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
        craftRemaining = 3;
        craftText = craftButton.GetComponentInChildren<Text>();
        RespawnAll();
        RespawnCoal();
        RespawnGift();
    }

    public void RespawnCoal()
    {
        Instantiate(coalPrefab, coalPos, Quaternion.Euler(new Vector3(-90f, 180f, 0f)));
    }

    public void RespawnGift()
    {
        Instantiate(emptyGiftPrefab, emptyGiftPos, Quaternion.Euler(new Vector3(-90f, 180f, 0f)));
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
        craftRemaining--;
        if (craftRemaining == 0)
            craftButton.interactable = false;
        craftText.text = "Recraft all toys" + System.Environment.NewLine + "(" + craftRemaining + " remaining)";
    }
}
