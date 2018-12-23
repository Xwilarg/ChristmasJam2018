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
            if (gift.Obj == GiftObject.GObject.Coal || gift.Wishes.Contains((int)gift.Obj))
                score = gift.Score * 10f * mutliplicator;
            else
                score = -100f;
            if (score > 100f)
                score = 100f;
            if (score < -100f)
                score = -100f;
            if (score < 0f)
                score *= 3f;
            text.text = "Score: " + (int.Parse(text.text.Split(' ').Last()) + Mathf.Round(score)).ToString();
            SpawnGift spawnGift = GameObject.FindGameObjectWithTag("GameManager").GetComponent<SpawnGift>();
            spawnGift.Spawn();
            Destroy(gameObject);
        }
    }
}
