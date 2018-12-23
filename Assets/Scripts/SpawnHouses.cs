using System.Collections.Generic;
using UnityEngine;

public class SpawnHouses : MonoBehaviour
{
    [SerializeField]
    private GameObject[] usaHouses, frenchHouses, japaneseHouses;

    private List<GameObject> allHouses = new List<GameObject>();

    public void ScrollHouses()
    {
        foreach (GameObject go in allHouses)
        {
            Destroy(go.AddComponent<ScrollHouse>(), 2f);
        }
    }

    private void Start()
    {
        WorldSelection ws = null;
        GameObject go = GameObject.FindGameObjectWithTag("WorldSelection");
        if (go != null)
            ws = go.GetComponent<WorldSelection>();
        WorldSelection.Country country = WorldSelection.Country.USA;
        if (ws != null)
            country = ws.country;
        GameObject[] houses;
        if (country == WorldSelection.Country.France)
            houses = frenchHouses;
        else if (country == WorldSelection.Country.Japan)
            houses = japaneseHouses;
        else
            houses = usaHouses;

        for (float y = 30000f; y > 100f; y -= 250f)
        {
            for (float i = -900f; i < 800f; i += 200f)
            {
                GameObject newGo = Instantiate(houses[Random.Range(0, houses.Length)], new Vector3(i, -100f, y), Quaternion.identity);
                newGo.transform.rotation = Quaternion.Euler(new Vector3(-90f, 0f, 0f));
                newGo.transform.localScale = new Vector3(1000f, 1000f, 1000f);
                allHouses.Add(newGo);
            }
        }
    }
}
