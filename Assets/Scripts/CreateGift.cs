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
            GiftObject giftObj = go.AddComponent<GiftObject>();
            giftObj.Obj = gift.Obj;
            giftObj.Wishes = GameObject.FindGameObjectWithTag("WishList").GetComponent<Wishlist>().wishesId;
            SpawnGift spawnGift = GameObject.FindGameObjectWithTag("GameManager").GetComponent<SpawnGift>();
            giftObj.Score = spawnGift.GetScore();
            go.transform.rotation = Quaternion.Euler(new Vector3(90f, 0f, 0f));
            spawnGift.Spawn();
            Destroy(other.gameObject);
            Destroy(transform.parent.gameObject);
        }
    }
}
