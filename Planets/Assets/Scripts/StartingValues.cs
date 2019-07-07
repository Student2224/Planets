using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingValues : MonoBehaviour
{
    public Vector2 ForceVector;
    public float ForceMagnitude;

    public Rigidbody2D rb2d;

    //private void Awake()
    //{
    //    rb2d = gameObject.GetComponent<Rigidbody2D>();
    //}

    private void Start()
    {
        rb2d.AddForce(ForceVector.normalized * ForceMagnitude);
    }
}
