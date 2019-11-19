using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float speed = 1.5f;
    public float rot_speed = 70f;
    protected SpaceShip space_ship;


    private void Awake()
    {
        space_ship = GetComponent<SpaceShip>();
    }

    private void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);  
        space_ship.forward = (Input.GetKey(KeyCode.W));
        space_ship.back = (Input.GetKey(KeyCode.S));
        space_ship.left = (Input.GetKey(KeyCode.A));
        space_ship.right = (Input.GetKey(KeyCode.D));
        space_ship.stop = (Input.GetKey(KeyCode.Space));
        space_ship.Rotate(mousePos);
    }


}
