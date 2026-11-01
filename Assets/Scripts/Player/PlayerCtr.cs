using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerCtr : MonoBehaviour
{
    private Animator animator;
    //private float x = 0;
    //private float y = 0;
    private float coefficient = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)) { coefficient = 1f; }
        if(Input.GetKeyUp(KeyCode.LeftShift)) { coefficient = 0.5f; }

        animator.SetFloat("y", Input.GetAxis("Vertical") * coefficient, 0.2f, Time.deltaTime);
        animator.SetFloat("x", Input.GetAxis("Horizontal") * coefficient, 0.2f, Time.deltaTime);
    }
}
