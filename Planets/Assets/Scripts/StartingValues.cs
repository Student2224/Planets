using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingValues : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public GameObject Sun;

    private Rigidbody2D SunRb2d;
    private Vector2 forceVector;

    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        SunRb2d = Sun.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        forceVector = Sun.transform.position - transform.position;
        forceVector = Vector2Extension.Rotate(forceVector, 90);

        rb2d.velocity += forceVector.normalized * Mathf.Sqrt(Attractor.G * SunRb2d.mass / Vector2.Distance(Sun.transform.position, transform.position));
    }
}
