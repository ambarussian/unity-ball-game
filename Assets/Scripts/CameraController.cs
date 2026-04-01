using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 distance;

    void Start()
    {
        distance = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = distance + player.transform.position;
    }
}
