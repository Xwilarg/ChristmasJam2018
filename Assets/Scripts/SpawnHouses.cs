using UnityEngine;

public class SpawnHouses : MonoBehaviour
{
    [SerializeField]
    private GameObject[] usaHouses, frenchHouses, japaneseHouses;

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

        for (float y = 800f; y > 100f; y -= 120f)
        {
            for (float i = -800f; i < 800f; i += 120f)
            {
                GameObject newGo = Instantiate(houses[Random.Range(0, houses.Length)], new Vector3(i, -100f, y), Quaternion.identity);
                newGo.transform.rotation = Quaternion.Euler(new Vector3(-90f, 0f, 0f));
                newGo.transform.localScale = new Vector3(1000f, 1000f, 1000f);
            }
        }
    }
}
