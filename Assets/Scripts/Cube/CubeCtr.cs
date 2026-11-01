using UnityEngine;

public class CubeCtr : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed;
    public float detectionRadius;
    public float acceleration;

    private float distance = 0f;
    private Vector3 orientation;
    private float currentSpeed;
    private float targetSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orientation = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        targetSpeed = 0;
        orientation = transform.position - playerTransform.position;
        orientation.y = 0f;
        distance = Vector3.Distance(transform.position, playerTransform.position);
        if (distance <= detectionRadius && distance >= 0.001f)
        {
            targetSpeed = moveSpeed;            
        }

        currentSpeed = Mathf.MoveTowards(currentSpeed,
                                         targetSpeed,
                                         acceleration * Time.deltaTime);

        transform.position += orientation.normalized * currentSpeed * Time.deltaTime;
    }
}
