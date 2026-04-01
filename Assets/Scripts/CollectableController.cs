using UnityEngine;

public class CollectableController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(45, 15, 15)*Time.deltaTime);
    }
}
