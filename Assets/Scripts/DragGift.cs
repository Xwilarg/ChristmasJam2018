using UnityEngine;

public class DragGift : MonoBehaviour
{
    [SerializeField]
    private FollowState state;

    private enum FollowState
    {
        OnlyFollow,
        Drop,
        Throw
    }

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
            Vector3 newPos = Camera.main.ScreenToWorldPoint(pos);
            newPos.z = 0f;
            transform.position = newPos;
        }
    }

    private void OnMouseDown()
    {
        followMouse = true;
    }

    private void OnMouseUp()
    {
        followMouse = false;
        if (state == FollowState.OnlyFollow)
            return;
        Vector3 mov = -(lastPos - transform.position) * launchMultiplicator;
        if (state == FollowState.Throw)
            mov.z = Mathf.Abs(mov.x + mov.y) * zMultiplicator;
        mov /= 2;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb == null)
            rb = gameObject.AddComponent<Rigidbody>();
        rb.AddForce(mov, ForceMode.Impulse);
        if (state == FollowState.Throw)
        {
            Destroy(gameObject, 10f);
            Destroy(this);
        }
    }
}
