using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Utils;

public class NaughtyList : MonoBehaviour
{
    [SerializeField]
    private Text naughtyList;

    private const int listSizeMin = 3;
    private const int listSizeMax = 8;

    private List<string> naughtyKids;

    private void Start()
    {
        naughtyKids = new List<string>();
        int nbKids = Random.Range(listSizeMin, listSizeMax);
        for (int i = 0; i < nbKids; i++)
            naughtyKids.Add(englishNames[Random.Range(0, englishNames.Length)].FirstName + " " + GenerateEuropeanLastName());
        naughtyList.text = string.Join(System.Environment.NewLine, naughtyKids);
    }
}
