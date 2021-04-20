using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] float forceRight;
    [SerializeField] float forceJump;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector2.up * forceJump);
        }

        
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(Vector2.right * forceRight *Time.fixedDeltaTime );
    }
}
