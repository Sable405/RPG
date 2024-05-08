using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    //WalkR and WalkL are reversd :(
    private Animator animator;
    public bool WalkL = false;
    public bool WalkR = false;
    public bool WalkS = false;
    public bool WalkW = false;
    public float speed;
    public float groundDist;

    public LayerMask terrainLayer;
    public Rigidbody rb;
    public SpriteRenderer sr;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 castPos = transform.position;
        castPos.y += 1;
        if (Physics.Raycast(castPos, -transform.up, out hit, Mathf.Infinity, terrainLayer))
        {
            if (hit.collider != null)
            {
                Vector3 movePos = transform.position;
                movePos.y = hit.point.y + groundDist;
                transform.position = movePos;
            }
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(x, 0, y);
        rb.velocity = moveDir * speed;

        

        if (Input.GetKeyDown(KeyCode.A))
        {
            WalkR = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            WalkR = false;
        }

        if (animator != null) // Check if animator is assigned
        {
            animator.SetBool("WalkR", WalkR);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            WalkL = true;
            
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            WalkL = false;
            
        }

        if (animator != null) // Check if animator is assigned
        {
            animator.SetBool("WalkL", WalkL);
        }

         if (Input.GetKeyDown(KeyCode.S))
        {
            WalkS = true;
            
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            WalkS = false;
            
        }

        if (animator != null) // Check if animator is assigned
        {
            animator.SetBool("WalkS", WalkS);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            WalkW = true;
            
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            WalkW = false;
            
        }

        if (animator != null) // Check if animator is assigned
        {
            animator.SetBool("WalkW", WalkW);
        }
    }

}
