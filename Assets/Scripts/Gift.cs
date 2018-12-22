using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Gift : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dest"))
        {
            Text text = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
            GiftObject gift = GetComponent<GiftObject>();
            float mutliplicator = 1;
            if (gift.Obj == GiftObject.GObject.Coal)
                mutliplicator *= -1f;
            float score;
            if (gift.Obj != GiftObject.GObject.Coal && GameObject.FindGameObjectWithTag("WishList").GetComponent<Wishlist>().wishesId.Contains((int)gift.Obj))
                score = Mathf.Clamp(gift.Score * 100f * mutliplicator, -100f, 100f);
            else
                score = -100f;
            text.text = "Score: " + (int.Parse(text.text.Split(' ').Last()) + (score)).ToString();
            Destroy(gameObject);
        }
    }
}
