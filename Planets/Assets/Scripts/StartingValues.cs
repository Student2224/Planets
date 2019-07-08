using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingValues : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public GameObject Sun;

    public Vector2 ForceVector;
    public float ForceMagnitude;



    //private void Awake()
    //{
    //    rb2d = gameObject.GetComponent<Rigidbody2D>();
    //}

    private void Start()
    {
        ForceMagnitude = GetComponent<Rigidbody2D>().mass * 50 * Mathf.Sqrt(Attractor.G * Sun.GetComponent<Rigidbody2D>().mass / Vector2.Distance(Sun.transform.position, transform.position));
        rb2d.AddForce(ForceVector.normalized * ForceMagnitude);
    }
}
