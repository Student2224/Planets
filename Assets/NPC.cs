using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    HashSet<GameObject> sky_bodies = new HashSet<GameObject>();
    HashSet<GameObject> player = new HashSet<GameObject>();
    protected Rigidbody2D componentRigidbody; //its rigidbody
    Vector3 target;

    private void Awake()
    {
        componentRigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            if (other.tag == "sky body")
            {
                sky_bodies.Add(other.gameObject);
            }

            if (other.tag == "player")
            {
                player.Add(other.gameObject);
            }
        }
    }
    void MoveToTarget(Vector3 target)
    {
        
    }
    void Algoritm()
    {
        foreach (var item in sky_bodies)
        {
            Vector3 distance = (item.transform.position - transform.position);
            if (distance.magnitude < 100)
            {
                componentRigidbody.AddForce(distance.normalized);
            }
        }
        foreach (var item in player)
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

