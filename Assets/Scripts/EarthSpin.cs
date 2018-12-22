using UnityEngine;

public class EarthSpin : MonoBehaviour
{
    [SerializeField]
    private Vector3 rot;

    [SerializeField]
    private float speed;

    private void Update()
    {
        transform.Rotate(rot * Time.deltaTime * speed);
    }
}
