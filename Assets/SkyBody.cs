using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBody : MonoBehaviour
{
    public bool isAttracted = true, // is this body attracted?
                isAttractor = true; // is this body attractor?
    public const float G = 6.674f / 1000; 
    protected Rigidbody2D componentRigidbody; //this rigidbody
    private HashSet<Rigidbody2D> affectedBodies = new HashSet<Rigidbody2D>(); //other rigidbodies in scena
    [SerializeField] private Vector2 startImpulse;


    private void Awake()
    {
        componentRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        componentRigidbody.velocity = startImpulse;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isAttracted)
        {
            if (other.attachedRigidbody != null && other.GetComponent<SkyBody>().isAttractor)
            {
                affectedBodies.Add(other.attachedRigidbody);
            }
        }
    }

    void Attract(Rigidbody2D body)
    {
        Vector2 dirrection = (transform.position - body.transform.position);
        float forceMagnitude = body.mass * componentRigidbody.mass / (dirrection.magnitude);
        componentRigidbody.AddForce(-dirrection.normalized * forceMagnitude);
    }

    void FixedUpdate()
    {
        foreach (Rigidbody2D body in affectedBodies)
        {
            Attract(body);
        }
    }
}