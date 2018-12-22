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
            float mutliplicator = 1f;
            if (gift.Obj == GiftObject.GObject.Coal)
                mutliplicator *= -1f;
            text.text = "Score: " + (int.Parse(text.text.Split(' ').Last()) + (gift.Score * 100f * mutliplicator)).ToString();
            Destroy(gameObject);
        }
    }
}
