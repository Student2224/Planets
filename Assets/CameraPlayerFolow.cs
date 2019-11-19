using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerFolow : MonoBehaviour
{
    [SerializeField]public SpaceShip target;
    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( target.transform.position.x,target.transform.position.y,transform.position.z);
    }
}
