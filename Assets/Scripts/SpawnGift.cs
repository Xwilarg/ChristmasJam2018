using UnityEngine;

public class SpawnGift : MonoBehaviour
{
    [SerializeField]
    private GameObject giftPrefab;

    public void Spawn()
    {
        Instantiate(giftPrefab, Vector3.zero, Quaternion.identity);
    }
}
