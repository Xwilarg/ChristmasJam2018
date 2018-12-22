using UnityEngine;

public class DragGift : MonoBehaviour
{
    private bool followMouse;
    private Vector3 lastPos;

    private const float launchMultiplicator = 60f;
    private const float zMultiplicator = 1.5f;

    private void Start()
    {
        followMouse = false;
    }

    private void Update()
    {
        if (followMouse)
        {
            lastPos = transform.position;
            Vector3 pos = Input.mousePosition;
            pos.z = transform.position.z - Camera.main.transform.position.z;
            transform.position = Camera.main.ScreenToWorldPoint(pos);
        }
    }

    private void OnMouseDown()
    {
        followMouse = true;
    }

    private void OnMouseUp()
    {
        followMouse = false;
        Vector3 mov = -(lastPos - transform.position) * launchMultiplicator;
        mov.z = Mathf.Abs(mov.x + mov.y) * zMultiplicator;
        gameObject.AddComponent<Rigidbody>().AddForce(mov, ForceMode.Impulse);
    }
}
