using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBody : MonoBehaviour
{
    public const float G = 6.674f / 1000;
    private Rigidbody2D componentRigidbody;
    private HashSet<Rigidbody2D> affectedBodies = new HashSet<Rigidbody2D>();
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
        if (other.attachedRigidbody!=null)
        {
            affectedBodies.Add(other.attachedRigidbody);
        }
    }

    void Attract(Rigidbody2D body)
    {
        Vector2 dirrection = (transform.position - body.transform.position);
        float forceMagnitude = body.mass/(dirrection.magnitude * componentRigidbody.mass);
        //print("HUY");
        body.AddForce(dirrection.normalized * forceMagnitude);
    }

    void FixedUpdate()
    {
        foreach (Rigidbody2D body in affectedBodies)
        {
                Attract(body);
        }
    }
 
 

 

}



//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using UnityEngine;

//public class SkyBody : MonoBehaviour
//{
//    protected Vector2 direction;
//    static protected GameObject[] go = GameObject.FindGameObjectsWithTag("sky body");
//    public Rigidbody2D body;

//    protected float radius;

//    public SkyBody(float m, float r,
//                      Vector2 posicion, Vector2 engine_force, Vector2 direction,
//                      Color color)
//    {
//        body.transform.position = posicion;
//        body.velocity = engine_force;
//        this.direction = direction;      
//        this.radius = radius;
//    }
//    void Interaction(SkyBody sky_body)
//    {
//        Vector2 force = (this.body.transform.position - sky_body.body.transform.position);
//        float distance = force.magnitude,
//              force_module = 1;
//        if (distance > 1)
//        {
//            force.Normalize();
//            force_module *= (float)-Math.Pow(distance, -2) * sky_body.body.mass;
//            force *= force_module / this.body.mass;
//            this.body.AddForce(force);
//        }
//    }
//    public void Interactions(List<SkyBody> bodys)
//    {
//        Parallel.ForEach(bodys, Interaction);
//    }
//    public void Move()
//    {
//        body.position += body.velocity;
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
//        transform.position = body.position;
//    }

//    // Update is called once per frame
//    void Update()
//    {

//        transform.position = body.position;
//    }
//}

