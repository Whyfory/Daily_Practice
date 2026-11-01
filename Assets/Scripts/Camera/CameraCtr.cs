using UnityEngine;

public class CameraCtr : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + distance;
    }
}
