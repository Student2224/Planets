using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    const float G = 6.674f;
     
    public static List<Attractor> Attractors = new List<Attractor>();

    public Rigidbody2D rb2d;

    void FixedUpdate()
    {
        foreach (Attractor attractor in Attractors)
        {
            if (attractor != this)
            {
                Attract(attractor);
            }
        }
    }

    private void OnEnable()
    {
        Attractors.Add(this);
    }

    private void OnDisable()
    {
        Attractors.Remove(this);
    }

    private void Attract(Attractor objToAttract)
    {
        Rigidbody2D rb2dToAttract = objToAttract.rb2d;

        Vector2 direction = rb2d.position - rb2dToAttract.position;
        float sqrdistance = direction.sqrMagnitude;

        if (sqrdistance == 0f)
        {
            return;
        }

        float forceMagnitude = G * (rb2d.mass * rb2dToAttract.mass) / sqrdistance;
        Vector3 force = direction.normalized * forceMagnitude;
        rb2dToAttract.AddForce(force);
    }
    
}
