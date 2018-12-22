using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] frenchHouses, usaHouses, japaneseHouses;

    private const float spawnRefTime = 2f;
    private float spawnTimer;

    public GameObject GetHouse()
    {
        WorldSelection ws = null;
        GameObject go = GameObject.FindGameObjectWithTag("WorldSelection");
        if (go != null)
            ws = go.GetComponent<WorldSelection>();
        WorldSelection.Country country = WorldSelection.Country.USA;
        if (ws != null)
            country = ws.country;
        if (country == WorldSelection.Country.France)
            return (frenchHouses[Random.Range(0, frenchHouses.Length)]);
        else if (country == WorldSelection.Country.Japan)
            return (null);
        else
            return (usaHouses[Random.Range(0, usaHouses.Length)]);
    }

    private void Start()
    {
        spawnTimer = spawnRefTime;
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer < 0f)
        {
            GameObject go = Instantiate(GetHouse(), Vector3.zero, Quaternion.identity);
            go.AddComponent<ScrollHouse>();
            spawnTimer = spawnRefTime;
        }
    }
}
