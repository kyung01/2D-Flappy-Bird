using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public delegate void DEL_BIRD_DEAD(Bird bird);
    public DEL_BIRD_DEAD hdrBirdDead;

    public static Bird Instance;

    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] Animator animator;

    [SerializeField] float forceRight;
    [SerializeField] float forceJump;



    bool isAlive = true;


    private void Awake()
    {
        Instance = this;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Reset()
    {
        isAlive = true;
        this.transform.position = new Vector3();
        animator.SetTrigger("alive");

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAlive)
        {
            return;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector2.up * forceJump);
        }

        
    }

    private void FixedUpdate()
    {
        if (!isAlive) return;
        rigidbody.AddForce(Vector2.right * forceRight *Time.fixedDeltaTime );
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        kill();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        kill();
    }

    void kill()
    {
        if (!isAlive) return;
        
        hdrBirdDead(this);

        isAlive = false;
        animator.SetTrigger("dead");


    }
}
