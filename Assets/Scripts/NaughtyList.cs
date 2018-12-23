using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static Utils;

public class NaughtyList : MonoBehaviour
{
    [SerializeField]
    private Text naughtyList;

    private const int listSizeMin = 10;
    private const int listSizeMax = 10;

    public struct FullName
    {
        public FullName(Name firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Name FirstName;
        public string LastName;
    }

    private List<FullName> naughtyKids;

    private void Start()
    {
        naughtyKids = new List<FullName>();
        int nbKids = Random.Range(listSizeMin, listSizeMax);
        for (int i = 0; i < nbKids; i++)
            naughtyKids.Add(GetFullName());
        naughtyList.text = string.Join(System.Environment.NewLine, naughtyKids.Select(x => x.FirstName.FirstName + " " + x.LastName));
    }

    public FullName GetNaugthyKid()
    {
        FullName full = naughtyKids[Random.Range(0, naughtyKids.Count)];
        naughtyKids.Remove(full);
        return (full);
    }
}
