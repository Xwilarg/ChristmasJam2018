using UnityEngine;

public class CreateGift : MonoBehaviour
{
    [SerializeField]
    private GameObject packedGift;

    public void OnTriggerEnter(Collider other)
    {
        GiftObject gift = other.GetComponent<GiftObject>();
        if (gift != null)
        {
            GameObject go = Instantiate(packedGift, new Vector3(transform.parent.position.x, transform.parent.position.y + 2f), Quaternion.identity);
            go.AddComponent<GiftObject>().Obj = gift.Obj;
            go.transform.rotation = Quaternion.Euler(new Vector3(90f, 0f, 0f));
            Destroy(other.gameObject);
            Destroy(transform.parent.gameObject);
        }
    }
}
